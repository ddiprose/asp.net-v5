using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using ClassLibrary1;

namespace net5WebPrototype.Controllers
{
    public class HomeController : Controller
    {
        private IvNextFeature _nextFeature;
        public HomeController(IvNextFeature nextFeature)
        {
            this._nextFeature = nextFeature;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public IEnumerable<string> GetAll()
        {
            return this._nextFeature.GetList();
        }

        public IActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}
