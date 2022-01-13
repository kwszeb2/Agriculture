using Microsoft.AspNetCore.Mvc;
using Agriculture.Models;

namespace Agriculture.Controllers
{
    public class LivestockController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
