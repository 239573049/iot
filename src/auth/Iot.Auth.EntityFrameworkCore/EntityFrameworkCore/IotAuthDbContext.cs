using Iot.Auth.Domain;
using Iot.Auth.Domain.Roles;
using Iot.Auth.Domain.Roles.Functions;
using Iot.Users;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Iot.Auth.EntityFrameworkCore.EntityFrameworkCore;

[ConnectionStringName("Default")]
public class IotAuthDbContext :
    AbpDbContext<IotAuthDbContext>
{

    public DbSet<Role> Role { get; set; }

    public DbSet<Menu> Menu { get; set; }

    public DbSet<AuthUserInfo> AuthUserInfo { get; set; }
    
    public DbSet<MenuRoleFunction> MenuRoleFunction { get; set; }

    public DbSet<UserRoleFunction> UserRoleFunction { get; set; }
    
    public IotAuthDbContext(DbContextOptions<IotAuthDbContext> options) : base(options)
    {
    }


    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Ignore<ExtraPropertyDictionary>();
        
        
        builder.Entity<AuthUserInfo>(x =>
        {
            x.ToTable("IotUserInfo");
            x.HasComment("用户信息");
            x.ConfigureByConvention();
            
        });
        
        builder.ConfigureAuth();
    }
}