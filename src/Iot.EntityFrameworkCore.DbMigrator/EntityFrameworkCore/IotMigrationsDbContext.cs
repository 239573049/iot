using Iot.Auth.EntityFrameworkCore.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;

namespace Iot.EntityFrameworkCore.DbMigrator.EntityFrameworkCore;

public class IotMigrationsDbContext : AbpDbContext<IotMigrationsDbContext>
{
    public IotMigrationsDbContext(DbContextOptions<IotMigrationsDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Ignore<ExtraPropertyDictionary>();
        
        builder.ConfigureSettingManagement();
        builder.ConfigureAuditLogging();
        builder.ConfigureFeatureManagement();

        #region iot系统

        builder.ConfigureIot();
        builder.ConfigureAuth();

        #endregion
    }
}