using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
    public class HomeController : Controller
    {
        [Route("/hello")]
        public string Hello() {return "hi mom";}

        [Route("/")]
        public ActionResult Letter()
        {
            LetterVariable myLetterVariable = new LetterVariable();
            myLetterVariable.Recipient = "Rose";
            myLetterVariable.Sender = "Emma";
            return View(myLetterVariable);
        }

        [Route("/form")]
        public ActionResult Form()
        {
            return View();
        }

        [Route("/postcard")]
        public ActionResult Postcard(string recipient, string sender)
        {
            LetterVariable myLetterVariable = new LetterVariable();
            myLetterVariable.Recipient = recipient;
            myLetterVariable.Sender = sender;
            return View(myLetterVariable);
        }
    }
}
