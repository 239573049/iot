using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Iot.EntityFrameworkCore.Dbmigrator.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AbpAuditLogs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicationName = table.Column<string>(type: "nvarchar(96)", maxLength: 96, nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    TenantId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TenantName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    ImpersonatorUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ImpersonatorUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ImpersonatorTenantId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ImpersonatorTenantName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    ExecutionTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExecutionDuration = table.Column<int>(type: "int", nullable: false),
                    ClientIpAddress = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    ClientName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    ClientId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    CorrelationId = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    BrowserInfo = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    HttpMethod = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
                    Url = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Exceptions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comments = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    HttpStatusCode = table.Column<int>(type: "int", nullable: true),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpAuditLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AbpFeatureValues",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    ProviderKey = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpFeatureValues", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AbpSettings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: false),
                    ProviderName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    ProviderKey = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeviceRunLogs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DeviceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Logs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceRunLogs", x => x.Id);
                },
                comment: "设备运行信息");

            migrationBuilder.CreateTable(
                name: "IotUserInfo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountNumber = table.Column<string>(type: "nvarchar(450)", nullable: true, comment: "账号"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "手机号"),
                    WeChatOpenId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(450)", nullable: true, comment: "密码"),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "头像"),
                    Introduce = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<int>(type: "int", nullable: false, comment: "账号状态"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "昵称"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IotUserInfo", x => x.Id);
                },
                comment: "用户信息");

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Index = table.Column<int>(type: "int", nullable: false),
                    Component = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "标题"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.Id);
                },
                comment: "菜单权限控制");

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "编码"),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "备注"),
                    Index = table.Column<int>(type: "int", nullable: false, comment: "排序"),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true, comment: "上一级id"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                },
                comment: "角色");

            migrationBuilder.CreateTable(
                name: "AbpAuditLogActions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenantId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AuditLogId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiceName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    MethodName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Parameters = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    ExecutionTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExecutionDuration = table.Column<int>(type: "int", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpAuditLogActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AbpAuditLogActions_AbpAuditLogs_AuditLogId",
                        column: x => x.AuditLogId,
                        principalTable: "AbpAuditLogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AbpEntityChanges",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AuditLogId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenantId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ChangeTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ChangeType = table.Column<byte>(type: "tinyint", nullable: false),
                    EntityTenantId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EntityId = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    EntityTypeFullName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpEntityChanges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AbpEntityChanges_AbpAuditLogs_AuditLogId",
                        column: x => x.AuditLogId,
                        principalTable: "AbpAuditLogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DeviceTemplates",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "模板名称"),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "图标"),
                    Type = table.Column<int>(type: "int", nullable: false, comment: "类型"),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "备注"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true, comment: "用户id"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceTemplates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeviceTemplates_IotUserInfo_UserId",
                        column: x => x.UserId,
                        principalTable: "IotUserInfo",
                        principalColumn: "Id");
                },
                comment: "设备模板");

            migrationBuilder.CreateTable(
                name: "menuRoleFunctions",
                columns: table => new
                {
                    MenuId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_menuRoleFunctions", x => new { x.MenuId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_menuRoleFunctions_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_menuRoleFunctions_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "菜单角色配置");

            migrationBuilder.CreateTable(
                name: "UserRoleFunctions",
                columns: table => new
                {
                    UserInfoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoleFunctions", x => new { x.UserInfoId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoleFunctions_IotUserInfo_UserInfoId",
                        column: x => x.UserInfoId,
                        principalTable: "IotUserInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoleFunctions_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "用户角色配置");

            migrationBuilder.CreateTable(
                name: "AbpEntityPropertyChanges",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenantId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EntityChangeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NewValue = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    OriginalValue = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    PropertyName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    PropertyTypeFullName = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpEntityPropertyChanges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AbpEntityPropertyChanges_AbpEntityChanges_EntityChangeId",
                        column: x => x.EntityChangeId,
                        principalTable: "AbpEntityChanges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IotDevices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stats = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserInfoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeviceTemplateId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IotDevices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IotDevices_DeviceTemplates_DeviceTemplateId",
                        column: x => x.DeviceTemplateId,
                        principalTable: "DeviceTemplates",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IotDevices_IotUserInfo_UserInfoId",
                        column: x => x.UserInfoId,
                        principalTable: "IotUserInfo",
                        principalColumn: "Id");
                },
                comment: "设备信息");

            migrationBuilder.InsertData(
                table: "IotUserInfo",
                columns: new[] { "Id", "AccountNumber", "Avatar", "CreationTime", "CreatorId", "DeletionTime", "Introduce", "Name", "Password", "PhoneNumber", "State", "WeChatOpenId" },
                values: new object[] { new Guid("4754a271-42d5-4e0d-8298-41b19dd00ab3"), "admin", "https://xiaohuchat.oss-cn-beijing.aliyuncs.com/ima/admin.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "超级管理员", "管理员", "dd666666", "13049809673", 0, null });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "Component", "ConcurrencyStamp", "CreationTime", "ExtraProperties", "Icon", "Index", "Name", "ParentId", "Path", "Title" },
                values: new object[,]
                {
                    { new Guid("044b20ff-34ed-432f-a61c-84f46f1f5cbf"), "@/pages/authority/menus/index", "227cb7998c7f4d178e0fa857d5e64ff1", new DateTime(2022, 9, 4, 23, 16, 51, 615, DateTimeKind.Local).AddTicks(3689), "{}", null, 2, "菜单管理", new Guid("f58d2feb-f9c7-4a5a-a761-78690fe3e895"), "/admin/authority/menu", "菜单管理" },
                    { new Guid("1d55c6a4-95ef-4ec7-924a-5f43a0dae42f"), "@/pages/devices/running-log/index", "2541dd6b6e0f47db86917db802146c56", new DateTime(2022, 9, 4, 23, 16, 51, 615, DateTimeKind.Local).AddTicks(3710), "{}", null, 1, "设备运行日志", new Guid("5ed82239-c2d3-4391-ab67-e752448f3816"), "/admin/devices/admin", "设备运行日志" },
                    { new Guid("4b3b6690-d5d6-4693-83f8-fb41c1c47bdb"), "@/pages/devices/template/index", "3a85f04cda0d49399c9bab7d9f3b345d", new DateTime(2022, 9, 4, 23, 16, 51, 615, DateTimeKind.Local).AddTicks(3702), "{}", null, 0, "设备模板", new Guid("5ed82239-c2d3-4391-ab67-e752448f3816"), "/admin/devices/template", "设备模板" },
                    { new Guid("5af12e31-2ce9-4160-84e0-c642b606e76d"), "@/pages/home/index", "eb465ace49a14e639b5a8fa6b615c2d2", new DateTime(2022, 9, 4, 23, 16, 51, 615, DateTimeKind.Local).AddTicks(3661), "{}", "HomeOutlined", 0, "首页", null, "/admin", "首页" },
                    { new Guid("5c1939e7-3143-4c6f-8489-5f05c4d5d938"), "@/pages/authority/users/index", "f1bf35c59fbf49199d3d85b1694640cb", new DateTime(2022, 9, 4, 23, 16, 51, 615, DateTimeKind.Local).AddTicks(3684), "{}", null, 1, "用户管理", new Guid("f58d2feb-f9c7-4a5a-a761-78690fe3e895"), "/admin/authority/user", "用户管理" },
                    { new Guid("5ed82239-c2d3-4391-ab67-e752448f3816"), null, "67fa0977e0f949b897ed874b5a886bca", new DateTime(2022, 9, 4, 23, 16, 51, 615, DateTimeKind.Local).AddTicks(3693), "{}", "DashboardOutlined", 2, "设备", null, "/admin/devices", "设备" },
                    { new Guid("b9a97cb5-3161-41fc-9d08-f1e2aebfbd2a"), "@/pages/authority/roles/index", "f6407f39e7f34fd097b823f871d78608", new DateTime(2022, 9, 4, 23, 16, 51, 615, DateTimeKind.Local).AddTicks(3676), "{}", null, 0, "角色管理", new Guid("f58d2feb-f9c7-4a5a-a761-78690fe3e895"), "/admin/authority/role", "角色管理" },
                    { new Guid("f58d2feb-f9c7-4a5a-a761-78690fe3e895"), "", "b0c9652638234eec87200ff38b53d939", new DateTime(2022, 9, 4, 23, 16, 51, 615, DateTimeKind.Local).AddTicks(3666), "{}", "SettingOutlined", 1, "权限管理", null, "/admin/authority", "权限管理" },
                    { new Guid("fcc79e87-cd8e-431c-b38f-3135fabff3e2"), "@/pages/devices/admin/index", "63df7f5b74324fffb90a891f5f766fb9", new DateTime(2022, 9, 4, 23, 16, 51, 615, DateTimeKind.Local).AddTicks(3714), "{}", null, 2, "设备管理", new Guid("5ed82239-c2d3-4391-ab67-e752448f3816"), "/admin/devices/admin", "设备管理" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Code", "ConcurrencyStamp", "CreationTime", "ExtraProperties", "Index", "Name", "ParentId", "Remark" },
                values: new object[] { new Guid("bcb5daa3-2cd0-4a89-958c-ce525688b791"), "admin", "e4f30f8cc16b4e8888a9ff5df7b00a8a", new DateTime(2022, 9, 4, 23, 16, 51, 615, DateTimeKind.Local).AddTicks(3561), "{}", 0, "管理员", null, "系统管理员" });

            migrationBuilder.InsertData(
                table: "DeviceTemplates",
                columns: new[] { "Id", "CreationTime", "CreatorId", "DeletionTime", "Icon", "Name", "Remark", "Type", "UserId" },
                values: new object[] { new Guid("58815bdd-614a-4d71-a1e0-d999c40479d0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "https://tokeniot.oss-cn-shenzhen.aliyuncs.com/icon/Dht.png", "温度计", "", 0, new Guid("4754a271-42d5-4e0d-8298-41b19dd00ab3") });

            migrationBuilder.InsertData(
                table: "UserRoleFunctions",
                columns: new[] { "RoleId", "UserInfoId" },
                values: new object[] { new Guid("bcb5daa3-2cd0-4a89-958c-ce525688b791"), new Guid("4754a271-42d5-4e0d-8298-41b19dd00ab3") });

            migrationBuilder.InsertData(
                table: "menuRoleFunctions",
                columns: new[] { "MenuId", "RoleId" },
                values: new object[,]
                {
                    { new Guid("044b20ff-34ed-432f-a61c-84f46f1f5cbf"), new Guid("bcb5daa3-2cd0-4a89-958c-ce525688b791") },
                    { new Guid("1d55c6a4-95ef-4ec7-924a-5f43a0dae42f"), new Guid("bcb5daa3-2cd0-4a89-958c-ce525688b791") },
                    { new Guid("4b3b6690-d5d6-4693-83f8-fb41c1c47bdb"), new Guid("bcb5daa3-2cd0-4a89-958c-ce525688b791") },
                    { new Guid("5af12e31-2ce9-4160-84e0-c642b606e76d"), new Guid("bcb5daa3-2cd0-4a89-958c-ce525688b791") },
                    { new Guid("5c1939e7-3143-4c6f-8489-5f05c4d5d938"), new Guid("bcb5daa3-2cd0-4a89-958c-ce525688b791") },
                    { new Guid("5ed82239-c2d3-4391-ab67-e752448f3816"), new Guid("bcb5daa3-2cd0-4a89-958c-ce525688b791") },
                    { new Guid("b9a97cb5-3161-41fc-9d08-f1e2aebfbd2a"), new Guid("bcb5daa3-2cd0-4a89-958c-ce525688b791") },
                    { new Guid("f58d2feb-f9c7-4a5a-a761-78690fe3e895"), new Guid("bcb5daa3-2cd0-4a89-958c-ce525688b791") },
                    { new Guid("fcc79e87-cd8e-431c-b38f-3135fabff3e2"), new Guid("bcb5daa3-2cd0-4a89-958c-ce525688b791") }
                });

            migrationBuilder.InsertData(
                table: "IotDevices",
                columns: new[] { "Id", "CreationTime", "CreatorId", "DeletionTime", "DeviceTemplateId", "LastTime", "Name", "Remark", "Stats", "UserInfoId" },
                values: new object[] { new Guid("fee8dc18-d869-4e9a-b345-98fe148065ca"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("58815bdd-614a-4d71-a1e0-d999c40479d0"), null, null, "", 1, new Guid("4754a271-42d5-4e0d-8298-41b19dd00ab3") });

            migrationBuilder.CreateIndex(
                name: "IX_AbpAuditLogActions_AuditLogId",
                table: "AbpAuditLogActions",
                column: "AuditLogId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpAuditLogActions_TenantId_ServiceName_MethodName_ExecutionTime",
                table: "AbpAuditLogActions",
                columns: new[] { "TenantId", "ServiceName", "MethodName", "ExecutionTime" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpAuditLogs_TenantId_ExecutionTime",
                table: "AbpAuditLogs",
                columns: new[] { "TenantId", "ExecutionTime" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpAuditLogs_TenantId_UserId_ExecutionTime",
                table: "AbpAuditLogs",
                columns: new[] { "TenantId", "UserId", "ExecutionTime" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpEntityChanges_AuditLogId",
                table: "AbpEntityChanges",
                column: "AuditLogId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpEntityChanges_TenantId_EntityTypeFullName_EntityId",
                table: "AbpEntityChanges",
                columns: new[] { "TenantId", "EntityTypeFullName", "EntityId" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpEntityPropertyChanges_EntityChangeId",
                table: "AbpEntityPropertyChanges",
                column: "EntityChangeId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpFeatureValues_Name_ProviderName_ProviderKey",
                table: "AbpFeatureValues",
                columns: new[] { "Name", "ProviderName", "ProviderKey" },
                unique: true,
                filter: "[ProviderName] IS NOT NULL AND [ProviderKey] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AbpSettings_Name_ProviderName_ProviderKey",
                table: "AbpSettings",
                columns: new[] { "Name", "ProviderName", "ProviderKey" },
                unique: true,
                filter: "[ProviderName] IS NOT NULL AND [ProviderKey] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceRunLogs_DeviceId",
                table: "DeviceRunLogs",
                column: "DeviceId");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceRunLogs_Id",
                table: "DeviceRunLogs",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceTemplates_UserId",
                table: "DeviceTemplates",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_IotDevices_DeviceTemplateId",
                table: "IotDevices",
                column: "DeviceTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_IotDevices_Id",
                table: "IotDevices",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_IotDevices_UserInfoId",
                table: "IotDevices",
                column: "UserInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_IotUserInfo_AccountNumber_Password",
                table: "IotUserInfo",
                columns: new[] { "AccountNumber", "Password" });

            migrationBuilder.CreateIndex(
                name: "IX_IotUserInfo_Id",
                table: "IotUserInfo",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_IotUserInfo_WeChatOpenId",
                table: "IotUserInfo",
                column: "WeChatOpenId");

            migrationBuilder.CreateIndex(
                name: "IX_menuRoleFunctions_MenuId_RoleId",
                table: "menuRoleFunctions",
                columns: new[] { "MenuId", "RoleId" });

            migrationBuilder.CreateIndex(
                name: "IX_menuRoleFunctions_RoleId",
                table: "menuRoleFunctions",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_Id",
                table: "Menus",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_ParentId",
                table: "Menus",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_Id",
                table: "Roles",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoleFunctions_RoleId",
                table: "UserRoleFunctions",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoleFunctions_UserInfoId_RoleId",
                table: "UserRoleFunctions",
                columns: new[] { "UserInfoId", "RoleId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AbpAuditLogActions");

            migrationBuilder.DropTable(
                name: "AbpEntityPropertyChanges");

            migrationBuilder.DropTable(
                name: "AbpFeatureValues");

            migrationBuilder.DropTable(
                name: "AbpSettings");

            migrationBuilder.DropTable(
                name: "DeviceRunLogs");

            migrationBuilder.DropTable(
                name: "IotDevices");

            migrationBuilder.DropTable(
                name: "menuRoleFunctions");

            migrationBuilder.DropTable(
                name: "UserRoleFunctions");

            migrationBuilder.DropTable(
                name: "AbpEntityChanges");

            migrationBuilder.DropTable(
                name: "DeviceTemplates");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "AbpAuditLogs");

            migrationBuilder.DropTable(
                name: "IotUserInfo");
        }
    }
}
