using Microsoft.AspNetCore.Mvc;
using Agriculture.Models;

namespace Agriculture.Controllers
{
    public class TechnologyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
