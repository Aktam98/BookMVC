using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using myBookApp.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myBookApp.Controllers
{
    public class PurchaseController : Controller
    {
        private readonly IPurchaseRepository _purchaseRepository;

        public PurchaseController(IPurchaseRepository purchaseRepository)
        {
            _purchaseRepository = purchaseRepository;
        }
        // GET: PurchaseController
        public ActionResult Index()
        {
            var result = _purchaseRepository.GetAllPurchases();
            return View(result);
        }

        // GET: PurchaseController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PurchaseController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PurchaseController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PurchaseController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PurchaseController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PurchaseController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PurchaseController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
