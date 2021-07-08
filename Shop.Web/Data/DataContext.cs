namespace Shop.Web.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using Shop.Web.Data.Entities;
    public class DataContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {

        }
    }
}

