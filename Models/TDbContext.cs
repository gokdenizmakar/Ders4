using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace Ders4.Models
{
    public class TDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost; Database=OrdersDb; trusted_connection = true");
        }
        public DbSet<WebUser> WebUsers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
