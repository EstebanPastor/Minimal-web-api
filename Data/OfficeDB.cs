using Microsoft.EntityFrameworkCore;
using Minimal_Api_PostreqSQLEF.Models;

namespace Minimal_Api_PostreqSQLEF.Data
{
    public class OfficeDB : DbContext
    {
        public OfficeDB(DbContextOptions<OfficeDB> options) : base(options) 
        { 

        }
        public DbSet<Employee> Employees => Set<Employee>();

    }
}
