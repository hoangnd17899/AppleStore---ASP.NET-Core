using System.IO;
using System;
using Microsoft.Extensions.Configuration;

namespace AppleStore
{
    public class GetConnectionString
    {
        public static string getConnectionString(){
            var config=GetConfiguration();
            var s= config.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;
            return s.ToString();
        }

        public static IConfigurationRoot GetConfiguration(){
            var builder=new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json",optional:true,reloadOnChange:false);
            return builder.Build();
        }
    }
}
