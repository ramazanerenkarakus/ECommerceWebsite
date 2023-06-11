using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ECommerceWebsite.MvcWebUI.Entity
{
    public class Product
    {
        public int Id { get; set; }
        [DisplayName("Ürün Adı")]
        public string ProductName { get; set; }
        [DisplayName("Ürün Açıklaması")]
        public string ProductDescription { get; set; }
        [DisplayName("Ürün Fiyatı")]
        public double ProductPrice { get; set; }
        [DisplayName("Ürün Stoğu")]
        public int ProductStock { get; set; }
        [DisplayName("Ürün Resmi")]
        public string Image{ get; set; }
        [DisplayName("Ana Sayfada mı?")]
        public bool IsHome { get; set; }
        [DisplayName("Onaylı mı ?")]
        public bool IsApproved { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; } 
    }
}