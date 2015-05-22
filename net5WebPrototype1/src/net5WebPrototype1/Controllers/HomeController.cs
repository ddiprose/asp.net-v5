using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using ClassLibrary1;
using System.Threading;

namespace net5WebPrototype.Controllers
{
    public class HomeController : Controller
    {
        private static Random _rnd = new Random();

        private static List<string> _db = new List<string> { "Yes", "No", "Definitely, yes", "I don't know", "Looks like, yes" };

        private IvNextFeature _nextFeature;
        public HomeController(IvNextFeature nextFeature)
        {
            this._nextFeature = nextFeature;
        }
        public IActionResult Index()
        {
            ViewBag.vNextFeatures = _nextFeature.GetList();

            return View();
        }

        public IActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpGet]
        public JsonResult GetAnswer()
        {
            int index = _rnd.Next(_db.Count);
            var answer = _db[index];
            return Json(answer);
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
