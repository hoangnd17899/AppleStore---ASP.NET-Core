using System;
using AppleStore.Entities;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace AppleStore.DL
{
    public class ProductDL
    {
        private string connectionString;

        public ProductDL(string _connectionString){
            connectionString=_connectionString;
        }

        /// <summary>
        /// Hàm lấy số lượng sản phẩm theo danh mục
        /// Nguyễn Đình Hoàng - 8/2/2020
        /// </summary>
        /// <param name="category">danh mục</param>
        /// <returns></returns>
        public int GetCountProductByCategory(string category){
            int count=0;
            var conn= DBContext.CreateConnection(connectionString);
            conn.Open();
            var cmd = new MySqlCommand();
            cmd.Connection=conn;

            if(category.Equals("all"))
            {
                cmd.CommandText="select count(*) from product";
            }
            else {
                cmd.CommandText="select count(*)\r\n" + 
                        "from product,category,product_category\r\n" + 
                        "where category.CategoryName='"+category+"'\r\n" + 
                        "	and category.CategoryID=product_category.CategoryID\r\n" + 
                        "    and product.ProductID=product_category.ProductID";
            }
            
            var reader = cmd.ExecuteReader();
            while(reader.Read()){
                count=reader.GetInt32(0);
            }
            conn.Close();
            return count;
        }

        /// <summary>
        /// Hàm lấy danh sách sản phẩm theo danh mục và phân trang
        /// Nguyễn Đình Hoàng - 8/2/2020
        /// </summary>
        /// <param name="category">danh mục</param>
        /// <param name="pageSize">số lượng sản phẩm hiển thị trên 1 trang</param>
        /// <param name="pageNumber">trang hiển thị</param>
        /// <returns></returns>        
        public List<Product> GetAllProductByCategory(string category, int pageSize, int pageNumber){
            List<Product> lst=new List<Product>(); 
            var conn= DBContext.CreateConnection(connectionString);
            conn.Open();
            var cmd = new MySqlCommand();
            cmd.Connection=conn;

            if(category.Equals("all"))
            {
                cmd.CommandText="select * from product limit "+pageSize+" offset "+(pageNumber-1)*pageSize;
            }
            else {
                cmd.CommandText="select product.*\r\n" + 
					"from product,category,product_category\r\n" + 
					"where category.CategoryName='"+category+"'\r\n" + 
					"	and category.CategoryID=product_category.CategoryID\r\n" + 
					"    and product.ProductID=product_category.ProductID limit "+pageSize+" offset "+(pageNumber-1)*pageSize;
            }
            
            var reader = cmd.ExecuteReader();
            while(reader.Read()){
                
                Product pro=new Product();
                pro.ProductID=reader.GetInt32("ProductID");
                pro.ProductName=reader.GetString("ProductName");
                pro.Price=reader.GetInt32("Price");
                pro.ScreenSize=reader.GetString("ScreenSize");
                pro.Weight=reader.GetString("Weight");
                pro.Origin=reader.GetString("Origin");
                pro.Image=reader.GetString("Image");
                if(reader["Thumbnail"]==DBNull.Value){
                    pro.Thumbnail=null;
                }else{
                    pro.Thumbnail=reader.GetString("Thumbnail");

                }
                pro.Description=reader.GetString("Description");

                lst.Add(pro);
            }
            conn.Close();
            return lst;
        }

        /// <summary>
        /// Hàm lấy thông tin chi tiết sản phẩm bằng id
        /// </summary>
        /// <param name="_id">id của sản phẩm trong db</param>
        /// <returns></returns>
        public Product GetProductByID(int _id){
            Product pro=new Product();

            var conn= DBContext.CreateConnection(connectionString);
            conn.Open();
            var cmd = new MySqlCommand();
            cmd.Connection=conn;
            cmd.CommandText="select * from product where ProductID="+_id;
            
            var reader = cmd.ExecuteReader();
            while(reader.Read()){
                pro.ProductID=reader.GetInt32("ProductID");
                pro.ProductName=reader.GetString("ProductName");
                pro.Price=reader.GetInt32("Price");
                pro.ScreenSize=reader.GetString("ScreenSize");
                pro.Weight=reader.GetString("Weight");
                pro.Origin=reader.GetString("Origin");
                pro.Image=reader.GetString("Image");
                if(reader["Thumbnail"]==DBNull.Value){
                    pro.Thumbnail=null;
                }else{
                    pro.Thumbnail=reader.GetString("Thumbnail");

                }
                pro.Description=reader.GetString("Description");
            }
            conn.Close();    

            return pro;
        }

        /// <summary>
        /// Hàm lấy danh sách sản phẩm có trong giỏ của khách hàng
        /// </summary>
        /// <param name="id">ID khách hàng</param>
        /// <returns>Danh sách sản phẩm</returns>
        public List<Product> GetProductsByCustomerID(int id){
            List<Product> lst=new List<Product>(); 
            var conn= DBContext.CreateConnection(connectionString);
            conn.Open();
            var cmd = new MySqlCommand();
            cmd.Connection=conn;

            cmd.CommandText="select product.*\r\n" + 
				" from product,customer_product\r\n" + 
				" where customer_product.CustomerID="+id+"\r\n" + 
				" and product.ProductID=customer_product.ProductID";
            
            var reader = cmd.ExecuteReader();
            while(reader.Read()){
                
                Product pro=new Product();
                pro.ProductID=reader.GetInt32("ProductID");
                pro.ProductName=reader.GetString("ProductName");
                pro.Price=reader.GetInt32("Price");
                pro.ScreenSize=reader.GetString("ScreenSize");
                pro.Weight=reader.GetString("Weight");
                pro.Origin=reader.GetString("Origin");
                pro.Image=reader.GetString("Image");
                if(reader["Thumbnail"]==DBNull.Value){
                    pro.Thumbnail=null;
                }else{
                    pro.Thumbnail=reader.GetString("Thumbnail");

                }
                pro.Description=reader.GetString("Description");

                lst.Add(pro);
            }
            conn.Close();
            return lst;
        }

        /// <summary>
        /// Hàm thêm sản phẩm vào giỏ hàng
        /// Nguyễn Đình Hoàng - 15/2/2020
        /// </summary>
        /// <param name="customerID">id khách hàng</param>
        /// <param name="productID">id sản phẩm</param>
        /// <returns></returns>
        public bool AddToCart(int customerID,int productID){
            var conn= DBContext.CreateConnection(connectionString);
            
            var cmd = new MySqlCommand();
            cmd.Connection=conn;
            try
            {
                conn.Open();
                cmd.CommandText="insert into customer_product(CustomerID,ProductID) "+
                "values(@customerid,@productid)";
                cmd.Parameters.Add(new MySqlParameter("customerid",customerID));
                cmd.Parameters.Add(new MySqlParameter("productid",productID));
                
                int reader = cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Hàm xóa sản phẩm khỏi giỏ hàng
        /// Nguyễn Đình Hoàng - 15/2/2020
        /// </summary>
        /// <param name="customerID">ID khách hàng</param>
        /// <param name="productID">ID sản phẩm</param>
        /// <returns></returns>
        public bool DeleteFromCart(int customerID,int productID){
            var conn= DBContext.CreateConnection(connectionString);
            
            var cmd = new MySqlCommand();
            cmd.Connection=conn;
            try
            {
                conn.Open();
                cmd.CommandText="delete from customer_product where CustomerID="+customerID+" and ProductID="+productID;
                
                int reader = cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
