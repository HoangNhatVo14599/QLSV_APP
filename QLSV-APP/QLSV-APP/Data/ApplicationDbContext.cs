using Microsoft.EntityFrameworkCore;
using QLSV_APP.Models;

namespace QLSV_APP.Controllers
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Students> Students { get; set; }


        
    }
}