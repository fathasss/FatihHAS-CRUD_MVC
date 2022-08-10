using FatihHAS1.Connect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FatihHAS1.Models
{
    public class Product :ConnString
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductStok { get; set; }
        public string ProductDescription { get; set; }

    }
}