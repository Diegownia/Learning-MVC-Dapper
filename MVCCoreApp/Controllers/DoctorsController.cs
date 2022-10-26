﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCCoreApp.Interfaces;
using MVCCoreApp.Models;

namespace MVCCoreApp.Controllers
{
    public class DoctorsController : Controller
    {

        private readonly IModelService _connection;

        public DoctorsController(IModelService connection)
        {
            _connection = connection;
        }


        // GET: DoctorsController
        public async Task<IActionResult> Index()
        {
            var index = await _connection.Index<Doctor>();
            return View(index);
        }

        // GET: DoctorsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DoctorsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DoctorsController/Create
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

        // GET: DoctorsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DoctorsController/Edit/5
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

        // GET: DoctorsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DoctorsController/Delete/5
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
