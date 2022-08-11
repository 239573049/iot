using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Iot.Data;

/* This is used if database provider does't define
 * IIotDbSchemaMigrator implementation.
 */
public class NullIotDbSchemaMigrator : IIotDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
