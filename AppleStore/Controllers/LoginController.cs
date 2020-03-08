using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AppleStore.DL;
using AppleStore.Entities;
using Microsoft.AspNetCore.Http;

namespace AppleStore
{
    public class LoginController : Controller
    {
        public string connectionString;
        CustomerDL dl;

        public LoginController(){
            connectionString=GetConnectionString.getConnectionString();
        }

        /// <summary>
        /// Hàm trả về trang đăng nhập
        /// Nguyễn Đình Hoàng - 6/2/2020
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Hàm đăng nhập
        /// Nguyễn Đình Hoàng - 10/2/2020
        /// </summary>
        /// <param name="model">đối tượng đăng nhập</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Index(CustomerLoginModel model){
            dl=new CustomerDL(connectionString);
            if(ModelState.IsValid){
                try{
                    Customer result=dl.Login(model.UserName,model.Password);
                    if(result!=null){
                        HttpContext.Session.SetObjectAsJson("userlogin",result);
                        return RedirectToAction("Index","Home");
                    }
                    else{
                        ViewData["errorlogin"]="Login Failed! Wrong User name or Password";
                        return View();
                    }
                }
                catch(Exception){
                    ViewData["errorlogin"]="Lỗi không kết nối được database";
                    return View();
                }
                
            }
            else{
                return View(model);
            }
        }

        /// <summary>
        /// Hàm đăng xuất khách hàng
        /// Nguyễn Đình Hoàng - 10/2/2020
        /// </summary>
        /// <returns></returns>
        public IActionResult Logout(){
            HttpContext.Session.Remove("userlogin");
            return RedirectToAction("Index","Home");
        }
    }
}