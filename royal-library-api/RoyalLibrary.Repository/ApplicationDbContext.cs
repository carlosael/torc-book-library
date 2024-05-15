using Microsoft.EntityFrameworkCore;
using RoyalLibrary.Domain.Entities;

namespace RoyalLibrary.Repository
{

public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
    }
}
