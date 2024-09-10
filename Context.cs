using Microsoft.EntityFrameworkCore;

namespace deneme12
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
        public Context()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

               
                optionsBuilder.UseNpgsql("Host=195.142.235.185;Port=5432;Username=unvocalrage;Password=b9C4Zl5yaI2r0EaAF0oU;Database=MustafaLibraryApp");
            }
        }

        public DbSet<Book> Books { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Model yapılandırmalarını burada yapabilirsiniz.
            modelBuilder.Entity<Book>().ToTable("Books");
        }

    }
}
