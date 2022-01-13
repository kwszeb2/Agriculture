using Microsoft.AspNetCore.Mvc;

namespace Agriculture.Controllers
{
    public class EquipmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
