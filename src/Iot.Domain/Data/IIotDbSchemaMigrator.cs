using System.Threading.Tasks;

namespace Iot.Data;

public interface IIotDbSchemaMigrator
{
    Task MigrateAsync();
}
