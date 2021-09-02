using Microsoft.AspNetCore.Mvc;

namespace portfolio.controllers
{
    public class HelloController : Controller
    {
        [HttpGet]
        [Route("")]
        public ViewResult Index()
        {
            return View();
        }
        [HttpGet("projects")]
        public ViewResult projects()
        {
            return View();
        }
        [HttpGet("contact")]
        public ViewResult contact()
        {
            return View();
        }
        [HttpGet("redirectPage")]
        public RedirectToActionResult RedirectPage()
        {
            return RedirectToAction("Index");
        }
    }
}
