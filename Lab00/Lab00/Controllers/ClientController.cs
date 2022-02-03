using Lab00.Helpers;
using Lab00.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Lab00.Controllers
{
    public class ClientController : Controller
    {


        // GET: ClientController1
        public ActionResult Index()
        {

            return View(Data.Instance.clientlist);

        }

       


        // GET: ClientController1/Details/5
        public ActionResult Details(int id)
        {
            var model = Data.Instance.clientlist.Find(client => client.Id == id);
            return View(model);
        }

        // GET: ClientController1/Create
        public ActionResult Create()
        {
            return View(new ClientModels());
        }

        // POST: ClientController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {

                var response = ClientModels.Save(new ClientModels
                {
                    Id = int.Parse(collection["Id"]),
                    FirstName = collection["FirstName"],
                    LastName = collection["LastName"],
                    Description = collection["Description"],
                    PhoneNumber = int.Parse(collection["PhoneNumber"])
                });


                if (response)
                {
                    return RedirectToAction(nameof(Index));
                }

                return View();

            }
            catch
            {
                return View();
            }
        }

        // GET: ClientController1/Edit/5
        public ActionResult Edit(int id)
        {
            var model = Data.Instance.clientlist.Find(client => client.Id == id);
            return View(model);
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
            var model = Data.Instance.clientlist.Find(client => client.Id == id);
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
