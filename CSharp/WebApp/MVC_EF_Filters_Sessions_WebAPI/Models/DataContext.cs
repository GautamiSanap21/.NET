using Microsoft.EntityFrameworkCore;

namespace MVC_EF_Filters_Sessions_WebAPI.Models
{
    public class DataContext : DbContext
    {
        public DbSet<Emp> emps { get; set; }

        public DataContext(DbContextOptions options):base(options) { }
    }
}
