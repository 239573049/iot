using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Iot.EntityFrameworkCore.DbMigrator.EntityFrameworkCore;

public class IotMigrationsDbContextFactory: IDesignTimeDbContextFactory<IotMigrationsDbContext>
{
    public IotMigrationsDbContext CreateDbContext(string[] args)
    {

        var configuration = BuildConfiguration();

        var connectionString = configuration.GetConnectionString(IotDbProperties.IotConnectionStringName);
        var builder = new DbContextOptionsBuilder<IotMigrationsDbContext>()
            .UseSqlServer(connectionString);

        return new IotMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Iot.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
    
}