using Microsoft.EntityFrameworkCore;

namespace RentApp.Infrastructure.Context
{
    public class RentContext : DbContext
    {
        public RentContext(DbContextOptions options) : base(options)
        { 
        }

       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(connectionString: "DataSource=dbo.RentFlatApi.db");
        }
    }
}