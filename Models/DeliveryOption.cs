using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StyleHub.Models
{
    public class DeliveryOption
    {
        [Key]
        public int DeliveryId { get; set; }

        public string DeliveryName { get; set;}
    }
}