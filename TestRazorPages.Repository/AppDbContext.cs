using Microsoft.EntityFrameworkCore;
using TestRazorPages.Models;

namespace TestRazorPages.Repository
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
