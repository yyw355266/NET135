using Microsoft.AspNetCore.Mvc;

namespace demo.UI.Controllers
{
    using demo.Models;
    using demo.BLL;
    public class ProductsController : Controller
    {
        private readonly IBLL<Products> bll;

        public ProductsController(IBLL<Products> bll) {
            this.bll = bll;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Add() {
            return View();
        }

        [HttpPost]
        public IActionResult Add([FromForm]Products pro)
        {
            ViewBag.rs= bll.Add(pro);
            return View();
        }
    }
}
