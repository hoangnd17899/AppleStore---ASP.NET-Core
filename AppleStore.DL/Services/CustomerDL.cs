using System;
using AppleStore.Entities;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace AppleStore.DL
{
    public class CustomerDL
    {
        private string connectionString;

        public CustomerDL(string _connectionString){
            connectionString=_connectionString;
        }

        /// <summary>
        /// Hàm kiểm tra tài khoản khi login
        /// Nguyễn Đình Hoàng - 9/2/2020
        /// </summary>
        /// <param name="userName">Tên đăng nhập</param>
        /// <param name="passWord">Mật khẩu</param>
        /// <returns>khách hàng</returns>
        public Customer Login(string userName,string passWord){
            Customer cus=null;
            var conn= DBContext.CreateConnection(connectionString);
            conn.Open();
            var cmd = new MySqlCommand();
            cmd.Connection=conn;

            cmd.CommandText="select * from customer where UserName='"+userName+"' and Password='"+passWord+"'";
            
            var reader = cmd.ExecuteReader();
            if(reader.Read()){
                cus=new Customer();
                cus.CustomerID=reader.GetInt32("CustomerID");
                cus.UserName=reader.GetString("UserName");
                cus.Password=reader.GetString("Password");
                cus.DisplayName=reader.GetString("DisplayName");
            }
            conn.Close();
            return cus;
        }

        /// <summary>
        /// Hàm tạo mới khách hàng
        /// Nguyễn Đình Hoàng - 11/2/2020
        /// </summary>
        /// <param name="username">tên đăng nhập</param>
        /// <param name="password">mật khẩu</param>
        /// <param name="displayname">Tên hiển thị</param>
        public bool Register(string username,string password,string displayname){
            var conn= DBContext.CreateConnection(connectionString);
            
            var cmd = new MySqlCommand();
            cmd.Connection=conn;
            try
            {
                conn.Open();
                cmd.CommandText="insert into customer(UserName,Password,DisplayName,CountCart) "+
                "values(@username,@password,@displayname,0)";
                cmd.Parameters.Add(new MySqlParameter("username",username));
                cmd.Parameters.Add(new MySqlParameter("password",password));
                cmd.Parameters.Add(new MySqlParameter("displayname",displayname));
                
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
