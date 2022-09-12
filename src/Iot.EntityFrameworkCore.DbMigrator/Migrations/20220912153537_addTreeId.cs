using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Iot.EntityFrameworkCore.Dbmigrator.Migrations
{
    public partial class addTreeId : Migration
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
                name: "TreeDevices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TreeDevices", x => x.Id);
                },
                comment: "设备树形");

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
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "类型"),
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
                    TreeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                table: "Menus",
                columns: new[] { "Id", "Component", "ConcurrencyStamp", "CreationTime", "ExtraProperties", "Icon", "Index", "Name", "ParentId", "Path", "Title" },
                values: new object[,]
                {
                    { new Guid("08fa9278-5395-4a53-bf27-4b46bff2b6d5"), "@/pages/devices/admin/index", "afab3e556cc3486db6020ee65e793429", new DateTime(2022, 9, 12, 23, 35, 37, 436, DateTimeKind.Local).AddTicks(5781), "{}", null, 2, "设备管理", new Guid("573b7241-38f5-4198-84a9-93a5f673540e"), "/devices/admin", "设备管理" },
                    { new Guid("11fac735-390c-4d1b-b299-950561216851"), "@/pages/devices/template/index", "6502bfc715664560abf18c4bf05aa867", new DateTime(2022, 9, 12, 23, 35, 37, 436, DateTimeKind.Local).AddTicks(5766), "{}", null, 0, "设备模板", new Guid("573b7241-38f5-4198-84a9-93a5f673540e"), "/devices/template", "设备模板" },
                    { new Guid("239b8ff3-81f1-4f62-91dd-558f4630b8ef"), "@/pages/home/index", "00aad36f432847f08344396693199b12", new DateTime(2022, 9, 12, 23, 35, 37, 436, DateTimeKind.Local).AddTicks(5729), "{}", "HomeOutlined", 0, "首页", null, "/admin", "首页" },
                    { new Guid("49a2f53e-7034-4823-ab75-cc7da17c6f81"), "@/pages/devices/running-log/index", "8029966ed10249deb4face7ce239ff5b", new DateTime(2022, 9, 12, 23, 35, 37, 436, DateTimeKind.Local).AddTicks(5777), "{}", null, 1, "设备运行日志", new Guid("573b7241-38f5-4198-84a9-93a5f673540e"), "/devices/running-log", "设备运行日志" },
                    { new Guid("573b7241-38f5-4198-84a9-93a5f673540e"), null, "55a4820cdeb545b68db8b4684db05a98", new DateTime(2022, 9, 12, 23, 35, 37, 436, DateTimeKind.Local).AddTicks(5761), "{}", "DashboardOutlined", 2, "设备", null, "/devices", "设备" },
                    { new Guid("ab874e3b-efeb-4c52-ac14-7b22a8a93bf8"), "@/pages/authority/users/index", "f8ccc83c75e24f81bf14fdd7fb7a4386", new DateTime(2022, 9, 12, 23, 35, 37, 436, DateTimeKind.Local).AddTicks(5752), "{}", null, 1, "用户管理", new Guid("cfbf0046-d5e3-4a25-bbe2-6896fb4bfb67"), "/authority/user", "用户管理" },
                    { new Guid("b6f60ec6-e522-4c09-8645-94fea2b870ae"), "@/pages/authority/roles/index", "48a8215c02d04fc792ebabf8a3f6822e", new DateTime(2022, 9, 12, 23, 35, 37, 436, DateTimeKind.Local).AddTicks(5747), "{}", null, 0, "角色管理", new Guid("cfbf0046-d5e3-4a25-bbe2-6896fb4bfb67"), "/authority/role", "角色管理" },
                    { new Guid("cfbf0046-d5e3-4a25-bbe2-6896fb4bfb67"), "", "b2cebf0f99964dfa9bbbc46cac491542", new DateTime(2022, 9, 12, 23, 35, 37, 436, DateTimeKind.Local).AddTicks(5742), "{}", "SettingOutlined", 1, "权限管理", null, "/authority", "权限管理" },
                    { new Guid("f2f49534-4dc7-4867-9629-468b73dacb8b"), "@/pages/authority/menus/index", "c6170945cd5a4be18f508ec3d86d9969", new DateTime(2022, 9, 12, 23, 35, 37, 436, DateTimeKind.Local).AddTicks(5756), "{}", null, 2, "菜单管理", new Guid("cfbf0046-d5e3-4a25-bbe2-6896fb4bfb67"), "/authority/menu", "菜单管理" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Code", "ConcurrencyStamp", "CreationTime", "ExtraProperties", "Index", "Name", "ParentId", "Remark" },
                values: new object[] { new Guid("bb177f9b-56b0-4178-a94e-ccd3fa079f19"), "admin", "a4e7ec82a2004f6d9cc2d642253dd214", new DateTime(2022, 9, 12, 23, 35, 37, 436, DateTimeKind.Local).AddTicks(5583), "{}", 0, "管理员", null, "系统管理员" });

            migrationBuilder.InsertData(
                table: "UserRoleFunctions",
                columns: new[] { "RoleId", "UserInfoId" },
                values: new object[] { new Guid("bb177f9b-56b0-4178-a94e-ccd3fa079f19"), new Guid("4754a271-42d5-4e0d-8298-41b19dd00ab3") });

            migrationBuilder.InsertData(
                table: "menuRoleFunctions",
                columns: new[] { "MenuId", "RoleId" },
                values: new object[,]
                {
                    { new Guid("08fa9278-5395-4a53-bf27-4b46bff2b6d5"), new Guid("bb177f9b-56b0-4178-a94e-ccd3fa079f19") },
                    { new Guid("11fac735-390c-4d1b-b299-950561216851"), new Guid("bb177f9b-56b0-4178-a94e-ccd3fa079f19") },
                    { new Guid("239b8ff3-81f1-4f62-91dd-558f4630b8ef"), new Guid("bb177f9b-56b0-4178-a94e-ccd3fa079f19") },
                    { new Guid("49a2f53e-7034-4823-ab75-cc7da17c6f81"), new Guid("bb177f9b-56b0-4178-a94e-ccd3fa079f19") },
                    { new Guid("573b7241-38f5-4198-84a9-93a5f673540e"), new Guid("bb177f9b-56b0-4178-a94e-ccd3fa079f19") },
                    { new Guid("ab874e3b-efeb-4c52-ac14-7b22a8a93bf8"), new Guid("bb177f9b-56b0-4178-a94e-ccd3fa079f19") },
                    { new Guid("b6f60ec6-e522-4c09-8645-94fea2b870ae"), new Guid("bb177f9b-56b0-4178-a94e-ccd3fa079f19") },
                    { new Guid("cfbf0046-d5e3-4a25-bbe2-6896fb4bfb67"), new Guid("bb177f9b-56b0-4178-a94e-ccd3fa079f19") },
                    { new Guid("f2f49534-4dc7-4867-9629-468b73dacb8b"), new Guid("bb177f9b-56b0-4178-a94e-ccd3fa079f19") }
                });

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
                name: "IX_TreeDevices_Id",
                table: "TreeDevices",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_TreeDevices_ParentId",
                table: "TreeDevices",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_TreeDevices_UserId",
                table: "TreeDevices",
                column: "UserId");

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
                name: "TreeDevices");

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
