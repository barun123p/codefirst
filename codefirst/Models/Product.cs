using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace codefirst.Models
{
    public class Product
    {
        public int ProductId { get; set; }

      
        public string Name { get; set; }

        public string Category { get; set; }

        public int Price { get; set; }

        //Navigation Property
        public ICollection<Review> Reviews { get; set; }
    }
    
}