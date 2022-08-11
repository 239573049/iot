using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Iot.Auth.EntityFrameworkCore.EntityFrameworkCore;

[ConnectionStringName("Default")]
public class IotAuthDbContext :
    AbpDbContext<IotAuthDbContext>
{
    public IotAuthDbContext(DbContextOptions<IotAuthDbContext> options) : base(options)
    {
    }


    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ConfigureAuth();
    }
}