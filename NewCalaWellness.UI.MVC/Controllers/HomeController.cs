using System.Web.Mvc;

namespace NewCalaWellness.UI.MVC.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AboutUs()
        {
            ViewBag.Message = "About Us.";

            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpGet]
        public ActionResult Therapy()
        {
            ViewBag.Message = "Therapy";

            return View();
        }
        [HttpGet]
        public ActionResult Services()
        {
            ViewBag.Message = "Services";

            return View();
        }
        [HttpGet]
        public ActionResult Testimonials()
        {
            ViewBag.Message = "Testimonials";

            return View();
        }
        [HttpGet]
        public ActionResult Pricing()
        {
            ViewBag.Message = "Coming Soon";

            return View();
        }
    }
}
