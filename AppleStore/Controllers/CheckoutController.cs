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
    public class CheckoutController : Controller
    {
        /// <summary>
        /// Hàm vào trang thanh toán
        /// Nguyễn Đình Hoàng - 19/2/2020
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            Customer cus = HttpContext.Session.GetObjectFromJson<Customer>("userlogin") ;
            if(cus!=null){
                return View();
            }
            else{
                return RedirectToAction("Index","Login");
            }
        }
    }
}