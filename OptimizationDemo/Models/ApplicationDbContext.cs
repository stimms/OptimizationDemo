using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace OptimizationDemo.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<IceCream> IceCreams { get; set; }
    }
}
