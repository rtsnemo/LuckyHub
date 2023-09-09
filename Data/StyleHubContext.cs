using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StyleHub.Data
{
    public class StyleHubContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public StyleHubContext() : base("name=StyleHubContext")
        {
        }

        public System.Data.Entity.DbSet<StyleHub.Models.Category> Categories { get; set; }

        public System.Data.Entity.DbSet<StyleHub.Models.Cloth> Clothes { get; set; }

        public System.Data.Entity.DbSet<StyleHub.Models.DeliveryOption> DeliveryOptions { get; set; }

        public System.Data.Entity.DbSet<StyleHub.Models.PurchaseRequest> PurchaseRequests { get; set; }
    }
}
