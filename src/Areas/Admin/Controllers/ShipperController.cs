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
    [Authorize(Roles = "Shipper,Admin")]
    public class ShipperController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IHubContext<OrderStatusHub> _hub;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly INotificationService _notificationService;

        public ShipperController(AppDbContext context, IHubContext<OrderStatusHub> hub,
            UserManager<ApplicationUser> userManager, INotificationService notificationService)
        {
            _context = context; _hub = hub; _userManager = userManager; _notificationService = notificationService;
        }

        public async Task<IActionResult> History() => View(await _context.Orders
            .Include(o => o.Address)
            .Where(o => o.Status == OrderStatus.Completed || o.Status == OrderStatus.Cancelled)
            .OrderByDescending(o => o.OrderDate).ToListAsync());

        public async Task<IActionResult> Index() => View(await _context.Orders.Include(o => o.Address)
            .Where(o => o.Status == OrderStatus.Preparing || o.Status == OrderStatus.Delivering).ToListAsync());

        [HttpPost]
        public async Task<IActionResult> PickUp(int orderId) => await ChangeStatus(orderId, OrderStatus.Delivering);
        [HttpPost]
        public async Task<IActionResult> CompleteDelivery(int orderId) => await ChangeStatus(orderId, OrderStatus.Completed);

        private async Task<IActionResult> ChangeStatus(int orderId, OrderStatus to)
        {
            var order = await _context.Orders.FindAsync(orderId);
            if (order != null && OrderStatusMachine.CanTransition(order.Status, to))
            {
                order.Status = to;
                await _context.SaveChangesAsync();

                var user = await _userManager.FindByIdAsync(order.UserId);
                if (user != null)
                {
                    try { await _notificationService.NotifyStatusChanged(order, user.Email!, user.PhoneNumber ?? ""); }
                    catch (Exception ex) { Console.WriteLine($"[Cảnh báo] Gửi thông báo thất bại: {ex.Message}"); }
                }

                await _hub.Clients.Group($"order-{order.Id}").SendAsync("StatusUpdated", order.Status.ToString());
            }
            return RedirectToAction("Index");
        }
    }
}
