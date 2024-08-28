using Microsoft.EntityFrameworkCore;
using MayBatch1AspCoreApp.Models;
namespace MayBatch1AspCoreApp.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Emp> emps { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<User> users { get; set; }
    }
}
