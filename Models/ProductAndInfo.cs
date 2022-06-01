using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MachineTest.Models
{
    public class ProductAndInfo
    {
        [Required]
        [MaxLength(50)]
        public string Product_Name { get; set; }

        public int Qty { get; set; }

        [MaxLength(8)]
        [Key]
        public string Sku { get; set; }


        public float Price { get; set; }

        [Key]
        public int ProductId { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        [MaxLength(25)]
        public string ProductCategory { get; set; }
    }
}