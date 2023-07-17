using Microsoft.AspNetCore.Mvc;

namespace FriendLetter.Controllers
{
    public class HomeController : Controller
    {
        [Route("/hello")]
        public string Hello() {return "hi mom";}

        [Route("/")]
        public ActionResult Letter() { return View(); }
    }
}
