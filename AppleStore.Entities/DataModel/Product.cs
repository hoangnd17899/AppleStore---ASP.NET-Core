using System;

namespace AppleStore.Entities
{
    public class Product
    {
        public int ProductID {get;set;}
        public string ProductName {get;set;}
        public int Price {get;set;}
        public string ScreenSize {get;set;}
        public string Weight {get;set;}
        public string Origin {get;set;}
        public string Image {get;set;}
        public string Thumbnail {get;set;}
        public string Description {get;set;}
    }
}
