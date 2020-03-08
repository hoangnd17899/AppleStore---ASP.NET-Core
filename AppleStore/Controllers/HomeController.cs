using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AppleStore.Entities;

namespace AppleStore
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Customer cus = HttpContext.Session.GetObjectFromJson<Customer>("userlogin");
            if(cus!=null){
                return View(cus);
            }
            return View();
        }
    }
}
