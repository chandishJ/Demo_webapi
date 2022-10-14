using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
namespace Demo_webapi.Models
{
    public class EmpDbContext : DbContext
    {
        public EmpDbContext(DbContextOptions<EmpDbContext> options)
            :base(options)
        {

        }
        public DbSet<Employee>? Employees { get; set; }
    }
}
