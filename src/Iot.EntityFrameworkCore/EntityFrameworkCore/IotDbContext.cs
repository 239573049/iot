using Iot.Devices;
using Iot.Users;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;

namespace Iot.EntityFrameworkCore;

[ConnectionStringName("Default")]
public class IotDbContext :
    AbpDbContext<IotDbContext>
{
    /* Add DbSet properties for your Aggregate Roots / Entities here. */

    #region Entities from the modules

    public DbSet<Device.Devices> IotDevices { get; set; }

    public DbSet<DeviceTemplate> DeviceTemplates { get; set; }

    public DbSet<DeviceRunLog> DeviceRunLogs { get; set; }
    
    public DbSet<UserInfo> UserInfo { get; set; }

    #endregion

    public IotDbContext(DbContextOptions<IotDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {

        builder.Ignore<ExtraPropertyDictionary>();
        /* Include modules to your migration db context */

        builder.ConfigureSettingManagement();
        builder.ConfigureAuditLogging();
        builder.ConfigureFeatureManagement();

        builder.ConfigureIot();
     
        base.OnModelCreating(builder);
    }
}