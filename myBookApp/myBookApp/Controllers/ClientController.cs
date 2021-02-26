using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using myBookApp.Models;
using myBookApp.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myBookApp.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClientRepository _clientRepository;
        private readonly IBookRepository _bookRepository;
        private readonly IPurchaseRepository _purchaseRepository;

        public ClientController(IPurchaseRepository purchaseRepository, IClientRepository clientRepository,IBookRepository bookRepository)
        {
            _clientRepository = clientRepository;
            _bookRepository = bookRepository;
            _purchaseRepository = purchaseRepository;
        }
        // GET: ClientController
        public ActionResult Index()
        {
            var result = _clientRepository.GetAllClient();
            return View(result);
        }

        // GET: ClientController/Details/5
        public ActionResult Details(int id)
        {
            var result = _clientRepository.GetClient(id);
            return View(result);
        }
        private Book books;
        // GET: ClientController/Create
        public ActionResult Create(int id)
        {
            books = _bookRepository.GetBook(id);
            return View(books);
        }

        // POST: ClientController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(int id,Client client)
        {
            try
            {
                Purchase purchase = new Purchase()
                {
                    ClientId = client.Id,
                    BookId = id
                };
                    

                _purchaseRepository.AddPurchase(purchase);
                _clientRepository.AddClient(id,client);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClientController/Edit/5
        public ActionResult Edit(int id)
        {
            var result = _clientRepository.GetClient(id);
            return View(result);
        }

        // POST: ClientController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Client client)
        {
            try
            {
                _clientRepository.UpdateClient(client);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClientController/Delete/5
        public ActionResult Delete(int id)
        {
            var result = _clientRepository.GetClient(id);
            return View(result);
        }

        // POST: ClientController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Client client)
        {
            try
            {
                _clientRepository.DeleteClient(client);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
