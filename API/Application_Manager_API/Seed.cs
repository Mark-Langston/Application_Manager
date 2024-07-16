using Application_Manager_API.Data;
using Application_Manager_API.Models;
using System.Collections.Generic;
using System.Linq;

namespace Application_Manager_API
{
    public class Seed
    {
        private readonly DataContext _context;

        public Seed(DataContext context)
        {
            _context = context;
        }

        public void SeedDataContext()
        {
            if (!_context.Applications.Any())
            {
                var applications = new List<Applications>
                {
                    new Applications { JobControl = 1, FirstName = "John", LastName = "Doe", HomeAddress = "123 Main St" },
                    new Applications { JobControl = 2, FirstName = "Jane", LastName = "Doe", HomeAddress = "456 Main St" },
                    // Add more seed data here
                };

                _context.Applications.AddRange(applications);
                _context.SaveChanges();
            }
        }
    }
}
