using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application_Manager_API.Data;
using Application_Manager_API.Models;

namespace Application_Manager_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ApplicationsController : ControllerBase
    {
        private readonly DataContext _context;

        public ApplicationsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/applications/{jobControl}
        [HttpGet("{jobControl}")]
        public async Task<ActionResult<IEnumerable<Applications>>> GetApplications(int jobControl)
        {
            // Query the database for applications with the specified jobControl
            var applications = await _context.Applications
                .Where(a => a.JobControl == jobControl)
                .ToListAsync();

            // Check if there are no applications found
            if (applications == null || applications.Count == 0)
            {
                return NotFound();
            }

            // Return the list of applications
            return applications;
        }
    }
}
