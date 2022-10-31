using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCCoreApp.Interfaces;
using MVCCoreApp.Models;
using MVCCoreApp.ViewModels;
using System.Linq;

namespace MVCCoreApp.Controllers
{
    public class VisitController : Controller
    {
        private readonly IModelService _connection;
        private readonly IMapper _mapper;

        public VisitController(IModelService connection, IMapper mapper)
        {
            _connection = connection;
            _mapper = mapper;
        }

        // GET: VisitController
        public async Task<IActionResult>Index()
        {
            var index = await _connection.Index<Visit>();
            var patients = await _connection.Index<Patient>();
            var visits = _mapper.Map<List<VisitViewModel>>(index);
            foreach (var visit in visits)
            {
                visit.PatientName = patients.FirstOrDefault(p => p.Id == visit.PatientId)?
                    .FullName ?? string.Empty;
            }
            return View(visits);
        }

        // GET: VisitController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VisitController/Create
        public async Task<IActionResult> Create()
        {
            var vm = new VisitViewModel();
            vm.Patients = await GetPatientList();
            return View(vm);
        }

        // POST: VisitController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(VisitViewModel vm)
        {
            var destination = new Visit();
            destination = _mapper.Map<Visit>(vm);
            var stored = await _connection.Store(destination);
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

        private async Task<IList<SelectListItem>> GetPatientList()
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
