using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OptimizationDemo.Models
{
    public class Vendor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string ManagerName { get; set; }

        public virtual ICollection<IceCream> IceCreams { get; set; }

        public Vendor()
        {
            IceCreams = new List<IceCream>();
        }
    }
}
