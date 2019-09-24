using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace H2.Oefening1.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult WhatsMyName()
        {
            //https://localhost:44349/Home/WhatsMyName

            string message = $"My name is: Valters Lukass Brosinskis, Today's date is: {DateTime.Now}";
            return Content(message, "text/plain");
        }

        public IActionResult Index()
        {
            string message = "<url>" + "<ul><li><a href='https://www.youtube.com/feed/subscriptions'>Youtube</a></li>"
                                    + "<li><a href='https://www.meteovista.be/Europa/Belgie/Nieuwpoort/4054553'>Weeronline</a></li>"
                                    + "<li><a href='https://www.facebook.com/'>Facebook</a></li></ul>";

            /*
            stringBuilder stringBuilder = new StringBuilder();
            */

            return Content(message, "text/html");
        }
    }
}