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
    }
}
