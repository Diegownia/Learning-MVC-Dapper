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

        public IActionResult Index()
        {
            _connection.Index<Patient>();
            return View();
        }
    }
}
