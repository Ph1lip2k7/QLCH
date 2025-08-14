using ASM1_VuThienTruong.Data;
using ASM1_VuThienTruong.Models; 
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore; 

namespace ASM1_VuThienTruong.Controllers
{
    public class HomeController : Controller
    {
        private readonly WebBanHangContext _context;

        public HomeController(WebBanHangContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            // Lấy ra 3 sản phẩm đầu tiên từ CSDL
            var products = await _context.Products.Take(3).ToListAsync();
            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = System.Diagnostics.Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}