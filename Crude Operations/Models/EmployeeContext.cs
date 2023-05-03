using Microsoft.EntityFrameworkCore;

namespace Crude_Operations.Models
{
    public class EmployeeContext : DbContext 
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {
            
        }

         public DbSet<Employee> Employees { get; set;}
    }
}
