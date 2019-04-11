using Microsoft.EntityFrameworkCore;

namespace RentApp.Infrastructure
{
    public class DbContext
    {
        protected DbContext(DbContextOptions options)
        {
            throw new System.NotImplementedException();
        }

        protected virtual void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            throw new System.NotImplementedException();
        }
    }
}