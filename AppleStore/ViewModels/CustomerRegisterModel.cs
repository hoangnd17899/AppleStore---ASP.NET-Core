using System;
using System.ComponentModel.DataAnnotations;

namespace AppleStore
{
    public class CustomerRegisterModel
    {
        [Required(ErrorMessage = "User name is required")]
        public string UserName {get;set;}
        [Required(ErrorMessage = "Password is required")]
        public string Password {get;set;}
        [Compare("Password", ErrorMessage = "Confirm password doesn't match, Type again !")]
        public string RepeatPassword {get;set;}
        [Required(ErrorMessage = "Dispplay name is required")]
        public string DisplayName {get;set;} 
    }
}
