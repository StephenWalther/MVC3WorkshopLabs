using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductsCatalog.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int UnitsInStock { get; set; }
        public int CategoryId { get; set; }       
    }
}