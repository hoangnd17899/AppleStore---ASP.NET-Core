using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AppleStore.DL;
using AppleStore.Entities; 
using Microsoft.Extensions.Configuration;

namespace AppleStore
{
    public class CartController : Controller
    {
        public string connectionString;
        ProductDL dl;

        public CartController(){
            connectionString=GetConnectionString.getConnectionString();
        }

        /// <summary>
        /// Hàm mở giỏ hàng
        /// Nguyễn Đình Hoàng - 13/2/2020
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

        /// <summary>
        /// API Service
        /// Hàm lấy danh sách sản phẩm trong giỏ hàng của khách hàng bằng ID
        /// Nguyễn Đình Hoàng - 13/2/2020
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("products/cart")]
        public AjaxResult GetProductsInCart(){
            dl=new ProductDL(connectionString);
            AjaxResult ajax = new AjaxResult();
            try
            {
                Customer cus = HttpContext.Session.GetObjectFromJson<Customer>("userlogin") ;
                ajax.Data = dl.GetProductsByCustomerID(cus.CustomerID);
            }
            catch (Exception ex)
            {
                ajax.Data = ex;
                ajax.Success = false;
                ajax.Message = "Hệ thống đang lỗi, vui lòng liên hệ nhân viên";
            }
            return ajax;
        }

        /// <summary>
        /// API Service
        /// Hàm xóa sản phẩm khỏi giỏ hàng
        /// Nguyễn Đình Hoàng - 15/2/2020
        /// </summary>
        /// <param name="productID">id sản phẩm</param>
        /// <returns></returns>
        [HttpDelete]
        [Route("products")]
        public AjaxResult DeleteFromCart(int productID){
            dl=new ProductDL(connectionString);
            AjaxResult ajax = new AjaxResult();
            try
            {
                Customer cus = HttpContext.Session.GetObjectFromJson<Customer>("userlogin") ;
                ajax.Data = dl.DeleteFromCart(cus.CustomerID,productID);
            }
            catch (Exception ex)
            {
                ajax.Data = ex;
                ajax.Success = false;
                ajax.Message = "Hệ thống đang lỗi, vui lòng liên hệ nhân viên";
            }
            return ajax;
        }
    }
}