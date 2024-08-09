using Book_Catalogue.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Book_Catalogue.Controllers
{
    public class HomeController(BookContext context) : Controller
    {
        private readonly BookContext _context = context;

        public IActionResult Index()
        {
            List<Books> books = _context.Books.ToList();
            return View(books);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Books book)
        {
            if (!ModelState.IsValid)
            {
                return View(book);
            }
            _context.Books.Add(book);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
