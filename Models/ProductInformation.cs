using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MachineTest.Models
{
    public class ProductInformation
    {
        [Key]
        public int ProductId { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        [MaxLength(25)]
        public string ProductCategory { get; set; }
    }
}