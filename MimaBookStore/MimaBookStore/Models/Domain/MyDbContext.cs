using Microsoft.EntityFrameworkCore;

namespace MimaBookStore.Models.Domain
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
            
        }

        public DbSet<Genre> Genre { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<Publisher> Publisher { get; set; }

    }
}
