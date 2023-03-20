using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Project_AdminPanel_.Models;

namespace Project_AdminPanel_.DAL
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions options): base(options)
        {
                
        }
        public DbSet<Order> Orders { get; set; }

    }
}
