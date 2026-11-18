using KhangThanhNhu_241224485.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;
namespace KhangThanhNhu_241224485.Controllers
{
    public class HomeController : Controller
    {
        private readonly QLNhaSachContext _context;
        public HomeController(QLNhaSachContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.TheLoai = _context.Set<TheLoai>().ToList();
            var dsSach = _context.Set<Sach>().Where(s => s.Gia >= 100).ToList();
            return View(dsSach);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
