using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Lab00.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab00.Controllers
{
    public class ClientController : Controller
    {
        // GET: ClientController1
        public ActionResult Index()
        {
            var list = new List<ClientModels>();
            {
                list.Add(new ClientModels
                {

                    FirstName = "Emilio",
                    LastName = "Barilas",
                    Description = "Cliente",
                    Id = 001,
                    PhoneNumber = 32084649,
                });



                return View(list);
            }
        }

        // GET: ClientController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClientController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClientController1/Create
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

        // GET: ClientController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClientController1/Edit/5
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

        // GET: ClientController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClientController1/Delete/5
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
