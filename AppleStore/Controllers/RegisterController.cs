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
    public class RegisterController : Controller
    {
        public string connectionString;
        CustomerDL dl;

        public RegisterController(){
            connectionString=GetConnectionString.getConnectionString();
        }

        /// <summary>
        /// Hàm trả về trang đăng ký tài khoản
        /// Nguyễn Đình Hoàng - 10/2/2020
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }     

        /// <summary>
        /// Hàm xử lý đăng ký tài khoản khách hàng
        /// Nguyễn Đình Hoàng - 10/2/2020
        /// </summary>
        /// <param name="model">Đối tượng khách hàng tầng View</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Index(CustomerRegisterModel model){
            dl=new CustomerDL(connectionString);
            if(ModelState.IsValid){
                bool result=dl.Register(model.UserName,model.Password,model.DisplayName);
                if(result){
                    return RedirectToAction("Index","Login");
                }
                else{
                    ViewData["error_register"]="Sign up failed! Username existing";
                    return View();
                }
            }
            else{
                return View(model);
            }
        }
    }
}
