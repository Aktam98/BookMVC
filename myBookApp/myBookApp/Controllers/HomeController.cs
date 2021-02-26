using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using myBookApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace myBookApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBookRepository _book;

        public HomeController(IBookRepository book)
        {
            _book = book;
        }

        public IActionResult Index()
        {
            var result = _book.GetAllBook();
            return View(result);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Book book)
        {
            _book.AddBook(book);
            return RedirectToAction(nameof(Index));
        }
     
        public ActionResult Edit(int id)
        {
            var book = _book.GetBook(id);
            return View(book);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Book book)
        {
            _book.UpdateBook(book);
            return RedirectToAction(nameof(Index));
        }
        public ActionResult Delete(int id)
        {
            var result = _book.GetBook(id);
            return View(result);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Book book)
        {
            _book.DeleteBook(book);
            return RedirectToAction(nameof(Index));
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
