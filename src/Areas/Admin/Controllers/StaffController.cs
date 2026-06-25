using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using HuongQueViet.Data;
using HuongQueViet.Helpers;
using HuongQueViet.Hubs;
using HuongQueViet.Models;
using HuongQueViet.Services;

namespace HuongQueViet.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Staff,Admin")]
    public class StaffController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IHubContext<OrderStatusHub> _hub;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly INotificationService _notificationService;

        public StaffController(AppDbContext context, IHubContext<OrderStatusHub> hub,
            UserManager<ApplicationUser> userManager, INotificationService notificationService)
        {
            _context = context; _hub = hub; _userManager = userManager; _notificationService = notificationService;
        }

        public async Task<IActionResult> History() => View(await _context.Orders
            .Include(o => o.OrderItems).ThenInclude(oi => oi.Product)
            .Where(o => o.Status == OrderStatus.Completed || o.Status == OrderStatus.Cancelled)
            .OrderByDescending(o => o.OrderDate).ToListAsync());

        public async Task<IActionResult> Index() => View(await _context.Orders
            .Include(o => o.OrderItems).ThenInclude(oi => oi.Product)
            .Where(o => o.Status == OrderStatus.Pending || o.Status == OrderStatus.Confirmed || o.Status == OrderStatus.Preparing)
            .OrderBy(o => o.OrderDate).ToListAsync());

        [HttpPost]
        public async Task<IActionResult> Advance(int orderId, OrderStatus toStatus)
        {
            var order = await _context.Orders.FindAsync(orderId);
            if (order == null) return NotFound();
            if (!OrderStatusMachine.CanTransition(order.Status, toStatus))
            {
                TempData["Error"] = $"Không thể chuyển từ {order.Status} sang {toStatus}";
                return RedirectToAction("Index");
            }
            order.Status = toStatus;
            await _context.SaveChangesAsync();

            var user = await _userManager.FindByIdAsync(order.UserId);
            if (user != null)
            {
                try { await _notificationService.NotifyStatusChanged(order, user.Email!, user.PhoneNumber ?? ""); }
                catch (Exception ex) { Console.WriteLine($"[Cảnh báo] Gửi thông báo thất bại: {ex.Message}"); }
            }

            await _hub.Clients.Group($"order-{order.Id}").SendAsync("StatusUpdated", order.Status.ToString());
            return RedirectToAction("Index");
        }
    }
}
