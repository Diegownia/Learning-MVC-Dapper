using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCCoreApp.Interfaces;
using MVCCoreApp.Models;

namespace MVCCoreApp.Controllers
{
    public class VisitController : Controller
    {

        private readonly IModelService _connection;

        public VisitController(IModelService connection)
        {
            _connection = connection;
        }

        // GET: VisitController
        public async Task<IActionResult>Index()
        {
            var index = await _connection.Index<Visit>();
            return View(index);
        }

        // GET: VisitController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VisitController/Create
        public async Task<IActionResult> Create()
        {
            await GetPatient();
            var model = await _connection.Create<Visit>();
            model.Patients = await PopulateList();
            return View(model);
        }

        // POST: VisitController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Visit model)
        {
            var stored = await _connection.Store(model);
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(stored);
            }
        }

        // GET: VisitController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VisitController/Edit/5
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

        // GET: VisitController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VisitController/Delete/5
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

        private async Task GetPatient()
        {
            var patientIndex = await _connection.Index<Patient>();

            var selectListItems = patientIndex.Select(p => new SelectListItem
            {
                Value = p.Id.ToString(),
                Text = p.Name
            });
        }

        private async Task<IList<SelectListItem>> PopulateList()
        {
            var patientIndex = await _connection.Index<Patient>();

            var selectListItems = patientIndex.Select(p => new SelectListItem
            {
                Value = p.Id.ToString(),
                Text = p.Name
            }).ToList();

            return selectListItems;
        }
    }
}
