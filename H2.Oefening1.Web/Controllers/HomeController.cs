using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace H2.Oefening1.Web.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {   
            return View();
        }

        public IActionResult WhatsMyName()
        {
            //https://localhost:44349/Home/WhatsMyName
            return Content("Valters Lukass Brosinskis - " + DateTime.Today);
        }
    }
}