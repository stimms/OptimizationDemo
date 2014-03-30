using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OptimizationDemo.Models
{
    public class IceCream
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Ingredient> Ingredients { get; set; }

        public virtual ICollection<Vendor> Vendors { get; set; }

        public IceCream()
        {
            Ingredients = new List<Ingredient>();
        }
    }
}