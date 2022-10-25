using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MVCCoreApp.Interfaces;
using MVCCoreApp.Models;

namespace MVCCoreApp.Controllers
{
    public class AppointmentController : Controller
    {

        private IModelService _connection;

        public AppointmentController(IModelService connection)
        {
            _connection = connection;
        }

        public async Task<IActionResult> Index()
        {
            var index = await _connection.Index<Patient>();

            return View(index);
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

        public async Task<IActionResult> Edit(Patient model)
        {
            await _connection.Update(model);
            return RedirectToAction(nameof(Index));
        }
    }
}
