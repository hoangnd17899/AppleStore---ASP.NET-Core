using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AppleStore.DL;
using AppleStore.Entities;

namespace AppleStore
{
    public class ShopController : Controller
    {
        public string connectionString;
        ProductDL dl;
        private int pageSize=12;
        
        public ShopController(){
            connectionString=GetConnectionString.getConnectionString();
        }

        /// <summary>
        /// Hàm hiển thị trang Shop
        /// Nguyễn Đình Hoàng - 7/2/2020
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            dl=new ProductDL(connectionString);
            ViewData["productscount"]=dl.GetCountProductByCategory("all");
            ViewData["pageSize"]=pageSize;
            return View();
        }

        /// <summary>
        /// API Service
        /// Hàm lấy danh sách sản phẩm theo danh mục và trang
        /// Nguyễn Đình Hoàng - 8/2/2020
        /// </summary>
        /// <param name="category">tên danh mục</param>
        /// <returns></returns>
        [HttpGet]
        [Route("products")]
        public AjaxResult GetProductByCategory(string category,int pageNumber){
            dl=new ProductDL(connectionString);
            AjaxResult ajax = new AjaxResult();
            try
            {
                if(pageNumber==0){
                    ajax.Data = dl.GetAllProductByCategory(category,pageSize,1);    
                }
                else{
                    ajax.Data = dl.GetAllProductByCategory(category,pageSize,pageNumber);    
                }
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
        /// Hàm lấy số lượng sản phẩm theo danh mục
        /// Nguyễn Đình Hoàng - 9/2/2020
        /// </summary>
        /// <param name="category">danh mục</param>
        /// <returns></returns>
        [HttpGet]
        [Route("products/count")]
        public AjaxResult GetCountByCategory(string category){
            dl=new ProductDL(connectionString);
            AjaxResult ajax = new AjaxResult();
            try
            {
                ajax.Data = dl.GetCountProductByCategory(category); 
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
        /// Hàm thêm sản phẩm vào giỏ hàng
        /// Nguyễn Đình Hoàng - 16/2/2020
        /// </summary>
        /// <param name="productID">ID sản phẩm</param>
        /// <returns></returns>
        public IActionResult AddToCart(int productID){
            dl=new ProductDL(connectionString);
            Customer customer=HttpContext.Session.GetObjectFromJson<Customer>("userlogin");
            if(customer==null){
                return RedirectToAction("Index","Login");
            }else{
                bool result=dl.AddToCart(customer.CustomerID,productID);
                return RedirectToAction("Index","Cart");
            }
        }
    }
}
