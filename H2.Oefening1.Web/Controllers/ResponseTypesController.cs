using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace H2.Oefening1.Web.Controllers
{
    public class ResponseTypesController : Controller
    {
        public IActionResult Fail()
        {
            return Content("Error 404: You've challanged the wrong cowboy, head back before it's too late!");
        }
    }
}