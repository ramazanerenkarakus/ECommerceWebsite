using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ECommerceWebsite.MvcWebUI.Models
{
    public class Register
    {
        [Required]
        [DisplayName("Adınız")]
        public string Name{ get; set; }

        [Required]
        [DisplayName("Soyadınız")]
        public string Surname{ get; set; }

        [Required]
        [DisplayName("Email Adresiniz")]
        [EmailAddress]
        public string Email{ get; set; }

        [Required]
        [DisplayName("Şifre")]
        public string Password{ get; set; }

        [Required]
        [DisplayName("Şifre Tekrar")]
        [Compare("Password",ErrorMessage = "Şifreleriniz aynı değil. Tekrar deneyin.")]
        public string RePassword{ get; set; }
    }
}