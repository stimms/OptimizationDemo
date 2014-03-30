using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OptimizationDemo.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Quanity { get; set; }
        public double CaloriesPerUnit { get; set; }

        public IList<IceCream> UsedIn { get; set; }



    }
}
