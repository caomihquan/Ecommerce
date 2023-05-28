using Ecore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce
{
    public class TenantDbContextFactory : IDesignTimeDbContextFactory<TenantDbContext>
    {
        public TenantDbContext CreateDbContext(string[] args)
        {
            var configrationBuilder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            var configuration = configrationBuilder.Build();
            var connectionString = configuration.GetConnectionString("TenantConnection");
            var dbContextOptionBuilder = new DbContextOptionsBuilder<TenantDbContext>();
            dbContextOptionBuilder.UseSqlServer(connectionString);
            return new TenantDbContext(dbContextOptionBuilder.Options);
        }
    }
}
