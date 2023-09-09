using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StyleHub.Models
{
    public class PurchaseRequest
    {
        [Key]
        public int PurchaseId { get; set; }
        [Required]

        public int ClothId { get; set; }
        [Required]

        public int DeliveryId {  get; set; }
        [Required]

        public string Name { get; set; }
        [Required]

        public string PhoneNumber { get; set; }
        [Required]

        public string Email { get; set; }

        public bool IsApproved { get; set; }

    }
}