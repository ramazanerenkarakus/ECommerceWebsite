﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ECommerceWebsite.MvcWebUI.Entity
{
    public class Category
    {
        public int Id { get; set; }
        [DisplayName("Kategori Adı")]
        public string CategoryName { get; set; }
        [DisplayName("Açıklama")]
        public string CategoryDescription { get; set; }

        public List<Product> Products { get; set; }
    }
}