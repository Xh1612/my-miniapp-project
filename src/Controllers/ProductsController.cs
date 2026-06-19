using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HuongQueViet.Data;

namespace HuongQueViet.Controllers
{
    // Controller công khai cho khách hàng xem chi tiết sản phẩm — KHÁC với Controller quản trị cùng tên trong Areas/Admin
    public class ProductsController : Controller
    {
        private readonly AppDbContext _context;
        public ProductsController(AppDbContext context) { _context = context; }

        public async Task<IActionResult> Details(int id)
        {
            var product = await _context.Products.Include(p => p.Category).FirstOrDefaultAsync(p => p.Id == id);
            if (product == null) return NotFound();

            var reviews = await _context.Reviews.Where(r => r.ProductId == id).OrderByDescending(r => r.CreatedAt).ToListAsync();
            ViewBag.Reviews = reviews;
            ViewBag.AverageRating = reviews.Any() ? Math.Round(reviews.Average(r => r.Rating), 1) : 0;
            return View(product);
        }
    }
}
