using Microsoft.EntityFrameworkCore;
using Application_Manager_API.Models;

namespace Application_Manager_API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Applications>().HasNoKey();
        }

        public DbSet<Applications> Applications { get; set; }
    }
}