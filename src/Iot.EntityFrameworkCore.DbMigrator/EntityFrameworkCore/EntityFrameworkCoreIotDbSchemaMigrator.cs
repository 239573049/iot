using Iot.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.DependencyInjection;

namespace Iot.EntityFrameworkCore.DbMigrator.EntityFrameworkCore;

public class EntityFrameworkCoreIotDbSchemaMigrator :
    IIotDbSchemaMigrator,ITransientDependency
{
    
    
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreIotDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }
    
    public async Task MigrateAsync()
    {
        
        await _serviceProvider
            .GetRequiredService<IotMigrationsDbContext>()
            .Database
            .MigrateAsync();
    }
}