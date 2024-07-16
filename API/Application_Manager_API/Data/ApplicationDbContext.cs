using Application_Manager_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Application_Manager_API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Applications> Applications { get; set; }
    }
}