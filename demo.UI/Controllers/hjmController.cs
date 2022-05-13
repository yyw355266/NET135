using Microsoft.AspNetCore.Mvc;

namespace demo.UI.Controllers
{
    public class hjmController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
