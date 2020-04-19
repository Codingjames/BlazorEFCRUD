using BlazorDemo.server2.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazorDemo.server2.Data
{
    public class AppDbContext:IdentityDbContext<AppUser>
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<CategoryModel> Categories { get; set; }
        
        public  AppDbContext(DbContextOptions<AppDbContext>  options):base(options)
        {

        }
    }
}