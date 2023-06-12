using ECommerceWebsite.MvcWebUI.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ECommerceWebsite.MvcWebUI.Identity
{
    public class IdentityInitializer : DropCreateDatabaseIfModelChanges<Context>
    {
    }
}