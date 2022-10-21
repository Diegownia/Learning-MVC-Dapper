using Microsoft.AspNetCore.Mvc;

namespace MVCCoreApp.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
