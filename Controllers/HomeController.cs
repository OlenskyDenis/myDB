using Microsoft.AspNetCore.Mvc;
using myDB.Data;
using myDB.Models;
using System.Diagnostics;

namespace myDB.Controllers
{
    public class HomeController : Controller
    {
        private readonly myDBContext _context;

        public HomeController(myDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var publications = _context.Publication.ToList();

            return View(publications);
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