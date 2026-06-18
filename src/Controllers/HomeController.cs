using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HuongQueViet.Data;

namespace HuongQueViet.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context) { _context = context; }

        public async Task<IActionResult> Index()
        {
            ViewBag.Featured = await _context.Products.Where(p => p.IsActive && p.IsFeatured).Take(4).ToListAsync();
            ViewBag.Newest = await _context.Products.Where(p => p.IsActive).OrderByDescending(p => p.CreatedAt).Take(4).ToListAsync();
            return View();
        }

        public IActionResult Privacy() => View();
    }
}
