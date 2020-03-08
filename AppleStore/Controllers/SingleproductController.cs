using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AppleStore.Entities;
using AppleStore.DL;

namespace AppleStore
{
    public class SingleproductController : Controller
    {
        public string connectionString;
        ProductDL dl;

        public SingleproductController(){
            connectionString=GetConnectionString.getConnectionString();
        }

        /// <summary>
        /// Hàm vào xem chi tiết sản phẩm
        /// Nguyễn Đình Hoàng - 11/2/2020
        /// </summary>
        /// <param name="id">id sản phẩm</param>
        /// <returns></returns>
        public IActionResult Index(int id)
        {
            dl=new ProductDL(connectionString);
            Product pro=dl.GetProductByID(id);
            return View(pro);
        }
    }
}