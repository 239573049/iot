using Iot.Auth.Domain;
using Iot.Auth.Domain.Roles;
using Iot.Auth.Domain.Roles.Functions;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Iot.Auth.EntityFrameworkCore.EntityFrameworkCore;

public static class IotAuthEntityFrameworkCoreExtension
{
    public static void ConfigureAuth(this ModelBuilder builder)
    {
        builder.Entity<Role>(x =>
        {
            x.ToTable("Roles");
            x.HasComment("角色");
            
            x.HasKey(x => x.Id);

            x.HasIndex(x => x.Id);

            x.Property(x => x.Code).HasComment("编码");

            x.Property(x => x.Index).HasComment("排序");

            x.Property(x => x.Remark).HasComment("备注");

            x.Property(x => x.ParentId).HasComment("上一级id");
        });

        
        builder.Entity<Menu>(x =>
        {
            x.ToTable("Menus");

            x.HasKey(x => x.Id);

            x.HasIndex(x => x.Id);
            
            x.HasComment("菜单权限控制");

            x.Property(x=>x.Title).HasComment("标题");

            x.HasIndex(x => x.ParentId);

        });

        builder.Entity<MenuRoleFunction>(x =>
        {
            x.ToTable("menuRoleFunctions");

            x.HasKey(x => x.Id);

            x.HasIndex(x => x.Id);

            x.HasComment("菜单角色配置");
            
        });

        builder.Entity<UserRoleFunction>(x =>
        {
            x.ToTable("UserRoleFunctions");

            x.HasComment("用户角色配置");
            
            x.HasKey(x => x.Id);

            x.HasIndex(x => x.Id);

        });
        
    }

}