using Microsoft.AspNetCore.Mvc;
using Agriculture.Models;

namespace Agriculture.Controllers
{
    public class FarmCropController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
