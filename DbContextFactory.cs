using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace deneme12
{
    public class DbContextFactory : IDesignTimeDbContextFactory<Context>
    {
        public Context CreateDbContext(string[] args = null)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()) // Projenizin çalışma dizini
                .AddXmlFile("App.config") // App.config dosyasını ekleyin
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<Context>();
            optionsBuilder.UseNpgsql("Host=195.142.235.185;Port=5432;Username=unvocalrage;Password=b9C4Zl5yaI2r0EaAF0oU;Database=MustafaLibraryApp");

            return new Context(optionsBuilder.Options);
        }
    }
}
