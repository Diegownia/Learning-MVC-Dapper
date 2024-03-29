﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MVCCoreApp.Interfaces;
using MVCCoreApp.Models;

namespace MVCCoreApp.Controllers
{
    public class AppointmentController : Controller
    {

        private readonly IModelService _connection;

        public AppointmentController(IModelService connection)
        {
            _connection = connection;
        }

        public async Task<IActionResult> Index()
        {
            var index = await _connection.Index<Patient>();

            return View(index);
        }

        public async Task<IActionResult> Details(int id)
        {
            var detail = await _connection.Show<Patient>(id);
            return View(detail);
        }

        // GET: AppointmentController/Create
        public async Task<IActionResult> Create()
        {
            var model = await _connection.Create<Patient>();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Patient model)
        {
            await _connection.Store(model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? Id)
        {
            await _connection.Edit<Patient>(Id);
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? Id,Patient patient)
        {
            if (Id == null) { return NotFound(); }
            var model = await _connection.Edit<Patient>(Id);

            await TryUpdateModelAsync(model);
            await _connection.Update(model);

            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(patient);
            }
        }
    }
}
