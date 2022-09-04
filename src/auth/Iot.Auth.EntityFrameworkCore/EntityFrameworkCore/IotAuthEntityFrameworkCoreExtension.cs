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
            x.ConfigureByConvention();

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
            x.ConfigureByConvention();
            x.HasKey(x => x.Id);

            x.HasIndex(x => x.Id);

            x.HasComment("菜单权限控制");

            x.Property(x => x.Title).HasComment("标题");

            x.HasIndex(x => x.ParentId);
        });

        builder.Entity<MenuRoleFunction>(x =>
        {
            x.ToTable("menuRoleFunctions");

            x.HasKey(x => new { x.MenuId, x.RoleId });

            x.HasIndex(x => new { x.MenuId, x.RoleId });

            x.HasComment("菜单角色配置");
        });

        builder.Entity<UserRoleFunction>(x =>
        {
            x.ToTable("UserRoleFunctions");

            x.HasComment("用户角色配置");

            x.HasKey(x => new { x.UserInfoId, x.RoleId });

            x.HasIndex(x => new { x.UserInfoId, x.RoleId });
        });

        builder.ConfigureDefaultData();
    }


    private static void ConfigureDefaultData(this ModelBuilder builder)
    {
        var roles = new Role(Guid.NewGuid(), "管理员", "admin", "系统管理员", 0, null, false, DateTime.Now);
        builder.Entity<Role>().HasData(roles);

        builder.Entity<UserRoleFunction>().HasData(new UserRoleFunction(Constants.AdminId, roles.Id));

        #region Device

        var home = new Menu(Guid.NewGuid(), 0, "@/pages/home/index", "首页", "首页", "HomeOutlined", "/admin", null);

        var authority = new Menu(Guid.NewGuid(), 1, "", "权限管理", "权限管理", "SettingOutlined", "/authority",
            null);
        var role = new Menu(Guid.NewGuid(), 0, "@/pages/authority/roles/index", "角色管理", "角色管理", null, "/authority/role",
            authority.Id);

        var user = new Menu(Guid.NewGuid(), 1, "@/pages/authority/users/index", "用户管理", "用户管理", null, "/authority/user",
            authority.Id);

        var menu = new Menu(Guid.NewGuid(), 2, "@/pages/authority/menus/index", "菜单管理", "菜单管理", null, "/authority/menu",
            authority.Id);

        var device = new Menu(Guid.NewGuid(), 2, null, "设备", "设备", "DashboardOutlined", "/devices", null);

        var deviceTemplate = new Menu(Guid.NewGuid(), 0, "@/pages/devices/template/index", "设备模板", "设备模板", null,
            "/devices/template", device.Id);

        var deviceRoles = new Menu(Guid.NewGuid(), 1, "@/pages/devices/running-log/index", "设备运行日志", "设备运行日志", null,
            "/devices/running-log", device.Id);

        var deviceAdmin = new Menu(Guid.NewGuid(), 2, "@/pages/devices/admin/index", "设备管理", "设备管理", null,
            "/devices/admin", device.Id);

        builder.Entity<Menu>()
            .HasData(home, authority, role, user, menu, device, deviceTemplate, deviceAdmin, deviceRoles);

        builder.Entity<MenuRoleFunction>().HasData(new MenuRoleFunction(home.Id, roles.Id),
            new MenuRoleFunction(authority.Id, roles.Id), new MenuRoleFunction(role.Id, roles.Id),
            new MenuRoleFunction(user.Id, roles.Id), new MenuRoleFunction(menu.Id, roles.Id),
            new MenuRoleFunction(device.Id, roles.Id), new MenuRoleFunction(deviceTemplate.Id, roles.Id),
            new MenuRoleFunction(deviceRoles.Id, roles.Id), new MenuRoleFunction(deviceAdmin.Id, roles.Id));

        #endregion
    }
}