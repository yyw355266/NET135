using Microsoft.AspNetCore.Mvc;

namespace demo.UI.Controllers
{
    public class NewsController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
