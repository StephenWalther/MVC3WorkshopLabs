using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Untyped_Views.Models
{
    public class ProductDetailsViewModel
    {
        public IList<Category> Categories { get; set; }
        public IList<Product> Products { get; set; }
    }
}