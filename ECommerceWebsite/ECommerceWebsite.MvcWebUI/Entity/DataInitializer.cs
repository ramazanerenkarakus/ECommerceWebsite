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

            var kategoriler = new List<Category>()
            {

                new Category(){CategoryName="Kamera",CategoryDescription="Kamera Ürünleri"},
                new Category(){CategoryName="Bilgisayar",CategoryDescription="Bilgisayar Ürünleri"},
                new Category(){CategoryName="Elektronik",CategoryDescription="Elektronik Ürünleri"},
                new Category(){CategoryName="Telefon",CategoryDescription="Telefon Ürünleri"},
                new Category(){CategoryName="Beyaz Eşya",CategoryDescription="Beyaz Eşya Ürünleri"}
            };

            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();

            var urunler = new List<Product>()
            {
                new Product(){ProductName="Samsung Kamera",ProductDescription="aaaaaaaa",ProductPrice=4500, ProductStock=100,IsApproved=true,CategoryId=1},
                new Product(){ProductName="Lenovo Kamera",ProductDescription="aaaaaaaa",ProductPrice=4500, ProductStock=100,IsApproved=true,CategoryId=1},
                new Product(){ProductName="Samsung Bilgisayar",ProductDescription="bbbbbbbb",ProductPrice=2000, ProductStock=200,IsApproved=false,CategoryId=2},
                new Product(){ProductName="Lenovo Bilgisayar",ProductDescription="bbbbbbbb",ProductPrice=5000, ProductStock=200,IsApproved=true,CategoryId=2},
                new Product(){ProductName="Samsung Elektronik",ProductDescription="asdasdas",ProductPrice=3000, ProductStock=300,IsApproved=true,CategoryId=3},
                new Product(){ProductName="Lenovo Elektronik",ProductDescription="asdasdas",ProductPrice=7000, ProductStock=300,IsApproved=false,CategoryId=3},
                new Product(){ProductName="Samsung Telefon",ProductDescription="ccccccccc",ProductPrice=4000, ProductStock=400,IsApproved=true,CategoryId=4},
                new Product(){ProductName="Lenovo Telefon",ProductDescription="ccccccccc",ProductPrice=8000, ProductStock=400,IsApproved=true,CategoryId=4},
                new Product(){ProductName="Samsung Beyaz Eşya",ProductDescription="dddddddd",ProductPrice=5000, ProductStock=500,IsApproved=false,CategoryId=5},
                new Product(){ProductName="Lenovo Beyaz Eşya",ProductDescription="dddddddd",ProductPrice=6000, ProductStock=500,IsApproved=true,CategoryId=5}
            };

            foreach(var urun in urunler)
            {
                context.Products.Add(urun);
            }
            context.SaveChanges();


            base.Seed(context);
        }
    }
}