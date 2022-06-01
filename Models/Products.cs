using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MachineTest.Models
{
    public class Products
    {
        [Required]
        [MaxLength(50)]
        public string Product_Name { get; set; }

        public int Qty { get; set; }

        [MaxLength(8)]
        [Key]
        public string Sku { get; set; }

      
        public float Price { get; set; }

        public Boolean Status { get; set ; } = true;

    }
}