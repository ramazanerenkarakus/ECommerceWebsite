using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ECommerceWebsite.MvcWebUI.Entity
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {

            var categories = new List<Category>()
            {

                new Category(){CategoryName="Kamera",CategoryDescription="Kamera Ürünleri"},
                new Category(){CategoryName="Bilgisayar",CategoryDescription="Bilgisayar Ürünleri"},
                new Category(){CategoryName="Elektronik",CategoryDescription="Elektronik Ürünleri"},
                new Category(){CategoryName="Telefon",CategoryDescription="Telefon Ürünleri"},
                new Category(){CategoryName="Beyaz Eşya",CategoryDescription="Beyaz Eşya Ürünleri"}
            };

            foreach (var category in categories)
            {
                context.Categories.Add(category);
            }
            context.SaveChanges();

            var products = new List<Product>()
            {
                new Product(){ProductName="Samsung Kamera",ProductDescription="Samsung Kamera",ProductPrice=4500, ProductStock=100,IsApproved=true,CategoryId=1,IsHome=true,Image="noImage.jpg"},
                new Product(){ProductName="Lenovo Kamera",ProductDescription="Lenovo Kamera Açıklaması",ProductPrice=4500, ProductStock=100,IsApproved=true,CategoryId=1},
                new Product(){ProductName="Samsung Bilgisayar",ProductDescription="Samsung Bilgisayar",ProductPrice=2000, ProductStock=200,IsApproved=false,CategoryId=2,Image="noImage.jpg"},
                new Product(){ProductName="Lenovo Bilgisayar",ProductDescription="Lenovo Bilgisayar",ProductPrice=5000, ProductStock=200,IsApproved=true,CategoryId=2,IsHome=true,Image="cameraphoto.png"},
                new Product(){ProductName="Samsung Elektronik",ProductDescription="Samsung Elektronik",ProductPrice=3000, ProductStock=300,IsApproved=true,CategoryId=3,Image="noImage.jpg"},
                new Product(){ProductName="Lenovo Elektronik",ProductDescription="Lenovo Elektronik",ProductPrice=7000, ProductStock=300,IsApproved=false,CategoryId=3,IsHome=true,Image="noImage.jpg"},
                new Product(){ProductName="Samsung Telefon",ProductDescription="Açıklama",ProductPrice=4000, ProductStock=400,IsApproved=true,CategoryId=4,IsHome=true,Image="noImage.jpg"},
                new Product(){ProductName="Lenovo Telefon",ProductDescription="Açıklama",ProductPrice=8000, ProductStock=400,IsApproved=true,CategoryId=4,Image="noImage.jpg"},
            };

            foreach(var product in products)
            {
                context.Products.Add(product);
            }
            context.SaveChanges();


            base.Seed(context);
        }
    }
}