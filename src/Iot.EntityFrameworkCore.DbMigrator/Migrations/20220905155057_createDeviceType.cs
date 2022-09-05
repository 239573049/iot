using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Iot.EntityFrameworkCore.Dbmigrator.Migrations
{
    public partial class createDeviceType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IotDevices",
                keyColumn: "Id",
                keyValue: new Guid("fee8dc18-d869-4e9a-b345-98fe148065ca"));

            migrationBuilder.DeleteData(
                table: "UserRoleFunctions",
                keyColumns: new[] { "RoleId", "UserInfoId" },
                keyValues: new object[] { new Guid("bcb5daa3-2cd0-4a89-958c-ce525688b791"), new Guid("4754a271-42d5-4e0d-8298-41b19dd00ab3") });

            migrationBuilder.DeleteData(
                table: "menuRoleFunctions",
                keyColumns: new[] { "MenuId", "RoleId" },
                keyValues: new object[] { new Guid("044b20ff-34ed-432f-a61c-84f46f1f5cbf"), new Guid("bcb5daa3-2cd0-4a89-958c-ce525688b791") });

            migrationBuilder.DeleteData(
                table: "menuRoleFunctions",
                keyColumns: new[] { "MenuId", "RoleId" },
                keyValues: new object[] { new Guid("1d55c6a4-95ef-4ec7-924a-5f43a0dae42f"), new Guid("bcb5daa3-2cd0-4a89-958c-ce525688b791") });

            migrationBuilder.DeleteData(
                table: "menuRoleFunctions",
                keyColumns: new[] { "MenuId", "RoleId" },
                keyValues: new object[] { new Guid("4b3b6690-d5d6-4693-83f8-fb41c1c47bdb"), new Guid("bcb5daa3-2cd0-4a89-958c-ce525688b791") });

            migrationBuilder.DeleteData(
                table: "menuRoleFunctions",
                keyColumns: new[] { "MenuId", "RoleId" },
                keyValues: new object[] { new Guid("5af12e31-2ce9-4160-84e0-c642b606e76d"), new Guid("bcb5daa3-2cd0-4a89-958c-ce525688b791") });

            migrationBuilder.DeleteData(
                table: "menuRoleFunctions",
                keyColumns: new[] { "MenuId", "RoleId" },
                keyValues: new object[] { new Guid("5c1939e7-3143-4c6f-8489-5f05c4d5d938"), new Guid("bcb5daa3-2cd0-4a89-958c-ce525688b791") });

            migrationBuilder.DeleteData(
                table: "menuRoleFunctions",
                keyColumns: new[] { "MenuId", "RoleId" },
                keyValues: new object[] { new Guid("5ed82239-c2d3-4391-ab67-e752448f3816"), new Guid("bcb5daa3-2cd0-4a89-958c-ce525688b791") });

            migrationBuilder.DeleteData(
                table: "menuRoleFunctions",
                keyColumns: new[] { "MenuId", "RoleId" },
                keyValues: new object[] { new Guid("b9a97cb5-3161-41fc-9d08-f1e2aebfbd2a"), new Guid("bcb5daa3-2cd0-4a89-958c-ce525688b791") });

            migrationBuilder.DeleteData(
                table: "menuRoleFunctions",
                keyColumns: new[] { "MenuId", "RoleId" },
                keyValues: new object[] { new Guid("f58d2feb-f9c7-4a5a-a761-78690fe3e895"), new Guid("bcb5daa3-2cd0-4a89-958c-ce525688b791") });

            migrationBuilder.DeleteData(
                table: "menuRoleFunctions",
                keyColumns: new[] { "MenuId", "RoleId" },
                keyValues: new object[] { new Guid("fcc79e87-cd8e-431c-b38f-3135fabff3e2"), new Guid("bcb5daa3-2cd0-4a89-958c-ce525688b791") });

            migrationBuilder.DeleteData(
                table: "DeviceTemplates",
                keyColumn: "Id",
                keyValue: new Guid("58815bdd-614a-4d71-a1e0-d999c40479d0"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("044b20ff-34ed-432f-a61c-84f46f1f5cbf"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("1d55c6a4-95ef-4ec7-924a-5f43a0dae42f"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("4b3b6690-d5d6-4693-83f8-fb41c1c47bdb"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("5af12e31-2ce9-4160-84e0-c642b606e76d"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("5c1939e7-3143-4c6f-8489-5f05c4d5d938"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("5ed82239-c2d3-4391-ab67-e752448f3816"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("b9a97cb5-3161-41fc-9d08-f1e2aebfbd2a"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("f58d2feb-f9c7-4a5a-a761-78690fe3e895"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("fcc79e87-cd8e-431c-b38f-3135fabff3e2"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("bcb5daa3-2cd0-4a89-958c-ce525688b791"));

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "DeviceTemplates",
                type: "nvarchar(max)",
                nullable: true,
                comment: "类型",
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "类型");

            migrationBuilder.InsertData(
                table: "DeviceTemplates",
                columns: new[] { "Id", "CreationTime", "CreatorId", "DeletionTime", "Icon", "Name", "Remark", "Type", "UserId" },
                values: new object[] { new Guid("0e2b485e-beb8-458c-8c38-67fbac758f0d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "https://tokeniot.oss-cn-shenzhen.aliyuncs.com/icon/Dht.png", "温度计", "备注", "温度计", new Guid("4754a271-42d5-4e0d-8298-41b19dd00ab3") });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "Component", "ConcurrencyStamp", "CreationTime", "ExtraProperties", "Icon", "Index", "Name", "ParentId", "Path", "Title" },
                values: new object[,]
                {
                    { new Guid("08e9e023-e5cb-4e94-8a42-e20fe8dc2785"), "@/pages/authority/roles/index", "e5c6d8fd3ce34d68a94b11a73632d88c", new DateTime(2022, 9, 5, 23, 50, 56, 767, DateTimeKind.Local).AddTicks(5387), "{}", null, 0, "角色管理", new Guid("fdc46d94-45fb-4ab1-aa0f-0e9f6e6d8865"), "/authority/role", "角色管理" },
                    { new Guid("0a89e690-4d8c-439d-a22f-ee6c650a2533"), "@/pages/devices/template/index", "cac51811ffd14d50887ca532ddbef5b1", new DateTime(2022, 9, 5, 23, 50, 56, 767, DateTimeKind.Local).AddTicks(5413), "{}", null, 0, "设备模板", new Guid("9b8045cd-c324-4aa6-9e50-f1d8f59cd55c"), "/devices/template", "设备模板" },
                    { new Guid("396627d4-5fd1-411c-8591-4466fd9703db"), "@/pages/authority/menus/index", "e8a66eb8e2a546969342cb447b08ea90", new DateTime(2022, 9, 5, 23, 50, 56, 767, DateTimeKind.Local).AddTicks(5402), "{}", null, 2, "菜单管理", new Guid("fdc46d94-45fb-4ab1-aa0f-0e9f6e6d8865"), "/authority/menu", "菜单管理" },
                    { new Guid("4b225133-a7b7-49c8-a74b-e042c44ce821"), "@/pages/home/index", "3df3a0ea54f540928933a948e9e3e235", new DateTime(2022, 9, 5, 23, 50, 56, 767, DateTimeKind.Local).AddTicks(5367), "{}", "HomeOutlined", 0, "首页", null, "/admin", "首页" },
                    { new Guid("67be2d62-6543-4ab6-a5e3-2ef986a87956"), "@/pages/devices/running-log/index", "207886490bd945538b6458135610a83e", new DateTime(2022, 9, 5, 23, 50, 56, 767, DateTimeKind.Local).AddTicks(5417), "{}", null, 1, "设备运行日志", new Guid("9b8045cd-c324-4aa6-9e50-f1d8f59cd55c"), "/devices/running-log", "设备运行日志" },
                    { new Guid("95829cd3-acb8-4731-94a2-a8c67dabc7df"), "@/pages/authority/users/index", "4eee053e7823444d8ff742bc3c041516", new DateTime(2022, 9, 5, 23, 50, 56, 767, DateTimeKind.Local).AddTicks(5392), "{}", null, 1, "用户管理", new Guid("fdc46d94-45fb-4ab1-aa0f-0e9f6e6d8865"), "/authority/user", "用户管理" },
                    { new Guid("9b8045cd-c324-4aa6-9e50-f1d8f59cd55c"), null, "f34b921c9fc740ab8eceee7dffa6a089", new DateTime(2022, 9, 5, 23, 50, 56, 767, DateTimeKind.Local).AddTicks(5407), "{}", "DashboardOutlined", 2, "设备", null, "/devices", "设备" },
                    { new Guid("bf0e44dd-e0c5-4cfa-8b74-5c89a4537d0d"), "@/pages/devices/admin/index", "c833d87b3179478fa2daf5c6c5982664", new DateTime(2022, 9, 5, 23, 50, 56, 767, DateTimeKind.Local).AddTicks(5421), "{}", null, 2, "设备管理", new Guid("9b8045cd-c324-4aa6-9e50-f1d8f59cd55c"), "/devices/admin", "设备管理" },
                    { new Guid("fdc46d94-45fb-4ab1-aa0f-0e9f6e6d8865"), "", "99871401c4d34096b2b88b77ef62509e", new DateTime(2022, 9, 5, 23, 50, 56, 767, DateTimeKind.Local).AddTicks(5376), "{}", "SettingOutlined", 1, "权限管理", null, "/authority", "权限管理" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Code", "ConcurrencyStamp", "CreationTime", "ExtraProperties", "Index", "Name", "ParentId", "Remark" },
                values: new object[] { new Guid("6061aafc-2312-4618-a579-5e8f6000c9b8"), "admin", "5d998894cb5b4465858a81a0687b17b8", new DateTime(2022, 9, 5, 23, 50, 56, 767, DateTimeKind.Local).AddTicks(5275), "{}", 0, "管理员", null, "系统管理员" });

            migrationBuilder.InsertData(
                table: "IotDevices",
                columns: new[] { "Id", "CreationTime", "CreatorId", "DeletionTime", "DeviceTemplateId", "LastTime", "Name", "Remark", "Stats", "UserInfoId" },
                values: new object[] { new Guid("7b7b9606-c979-4022-8506-ae2ef718298c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("0e2b485e-beb8-458c-8c38-67fbac758f0d"), null, null, "", 1, new Guid("4754a271-42d5-4e0d-8298-41b19dd00ab3") });

            migrationBuilder.InsertData(
                table: "UserRoleFunctions",
                columns: new[] { "RoleId", "UserInfoId" },
                values: new object[] { new Guid("6061aafc-2312-4618-a579-5e8f6000c9b8"), new Guid("4754a271-42d5-4e0d-8298-41b19dd00ab3") });

            migrationBuilder.InsertData(
                table: "menuRoleFunctions",
                columns: new[] { "MenuId", "RoleId" },
                values: new object[,]
                {
                    { new Guid("08e9e023-e5cb-4e94-8a42-e20fe8dc2785"), new Guid("6061aafc-2312-4618-a579-5e8f6000c9b8") },
                    { new Guid("0a89e690-4d8c-439d-a22f-ee6c650a2533"), new Guid("6061aafc-2312-4618-a579-5e8f6000c9b8") },
                    { new Guid("396627d4-5fd1-411c-8591-4466fd9703db"), new Guid("6061aafc-2312-4618-a579-5e8f6000c9b8") },
                    { new Guid("4b225133-a7b7-49c8-a74b-e042c44ce821"), new Guid("6061aafc-2312-4618-a579-5e8f6000c9b8") },
                    { new Guid("67be2d62-6543-4ab6-a5e3-2ef986a87956"), new Guid("6061aafc-2312-4618-a579-5e8f6000c9b8") },
                    { new Guid("95829cd3-acb8-4731-94a2-a8c67dabc7df"), new Guid("6061aafc-2312-4618-a579-5e8f6000c9b8") },
                    { new Guid("9b8045cd-c324-4aa6-9e50-f1d8f59cd55c"), new Guid("6061aafc-2312-4618-a579-5e8f6000c9b8") },
                    { new Guid("bf0e44dd-e0c5-4cfa-8b74-5c89a4537d0d"), new Guid("6061aafc-2312-4618-a579-5e8f6000c9b8") },
                    { new Guid("fdc46d94-45fb-4ab1-aa0f-0e9f6e6d8865"), new Guid("6061aafc-2312-4618-a579-5e8f6000c9b8") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IotDevices",
                keyColumn: "Id",
                keyValue: new Guid("7b7b9606-c979-4022-8506-ae2ef718298c"));

            migrationBuilder.DeleteData(
                table: "UserRoleFunctions",
                keyColumns: new[] { "RoleId", "UserInfoId" },
                keyValues: new object[] { new Guid("6061aafc-2312-4618-a579-5e8f6000c9b8"), new Guid("4754a271-42d5-4e0d-8298-41b19dd00ab3") });

            migrationBuilder.DeleteData(
                table: "menuRoleFunctions",
                keyColumns: new[] { "MenuId", "RoleId" },
                keyValues: new object[] { new Guid("08e9e023-e5cb-4e94-8a42-e20fe8dc2785"), new Guid("6061aafc-2312-4618-a579-5e8f6000c9b8") });

            migrationBuilder.DeleteData(
                table: "menuRoleFunctions",
                keyColumns: new[] { "MenuId", "RoleId" },
                keyValues: new object[] { new Guid("0a89e690-4d8c-439d-a22f-ee6c650a2533"), new Guid("6061aafc-2312-4618-a579-5e8f6000c9b8") });

            migrationBuilder.DeleteData(
                table: "menuRoleFunctions",
                keyColumns: new[] { "MenuId", "RoleId" },
                keyValues: new object[] { new Guid("396627d4-5fd1-411c-8591-4466fd9703db"), new Guid("6061aafc-2312-4618-a579-5e8f6000c9b8") });

            migrationBuilder.DeleteData(
                table: "menuRoleFunctions",
                keyColumns: new[] { "MenuId", "RoleId" },
                keyValues: new object[] { new Guid("4b225133-a7b7-49c8-a74b-e042c44ce821"), new Guid("6061aafc-2312-4618-a579-5e8f6000c9b8") });

            migrationBuilder.DeleteData(
                table: "menuRoleFunctions",
                keyColumns: new[] { "MenuId", "RoleId" },
                keyValues: new object[] { new Guid("67be2d62-6543-4ab6-a5e3-2ef986a87956"), new Guid("6061aafc-2312-4618-a579-5e8f6000c9b8") });

            migrationBuilder.DeleteData(
                table: "menuRoleFunctions",
                keyColumns: new[] { "MenuId", "RoleId" },
                keyValues: new object[] { new Guid("95829cd3-acb8-4731-94a2-a8c67dabc7df"), new Guid("6061aafc-2312-4618-a579-5e8f6000c9b8") });

            migrationBuilder.DeleteData(
                table: "menuRoleFunctions",
                keyColumns: new[] { "MenuId", "RoleId" },
                keyValues: new object[] { new Guid("9b8045cd-c324-4aa6-9e50-f1d8f59cd55c"), new Guid("6061aafc-2312-4618-a579-5e8f6000c9b8") });

            migrationBuilder.DeleteData(
                table: "menuRoleFunctions",
                keyColumns: new[] { "MenuId", "RoleId" },
                keyValues: new object[] { new Guid("bf0e44dd-e0c5-4cfa-8b74-5c89a4537d0d"), new Guid("6061aafc-2312-4618-a579-5e8f6000c9b8") });

            migrationBuilder.DeleteData(
                table: "menuRoleFunctions",
                keyColumns: new[] { "MenuId", "RoleId" },
                keyValues: new object[] { new Guid("fdc46d94-45fb-4ab1-aa0f-0e9f6e6d8865"), new Guid("6061aafc-2312-4618-a579-5e8f6000c9b8") });

            migrationBuilder.DeleteData(
                table: "DeviceTemplates",
                keyColumn: "Id",
                keyValue: new Guid("0e2b485e-beb8-458c-8c38-67fbac758f0d"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("08e9e023-e5cb-4e94-8a42-e20fe8dc2785"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("0a89e690-4d8c-439d-a22f-ee6c650a2533"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("396627d4-5fd1-411c-8591-4466fd9703db"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("4b225133-a7b7-49c8-a74b-e042c44ce821"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("67be2d62-6543-4ab6-a5e3-2ef986a87956"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("95829cd3-acb8-4731-94a2-a8c67dabc7df"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("9b8045cd-c324-4aa6-9e50-f1d8f59cd55c"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("bf0e44dd-e0c5-4cfa-8b74-5c89a4537d0d"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("fdc46d94-45fb-4ab1-aa0f-0e9f6e6d8865"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6061aafc-2312-4618-a579-5e8f6000c9b8"));

            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "DeviceTemplates",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "类型",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComment: "类型");

            migrationBuilder.InsertData(
                table: "DeviceTemplates",
                columns: new[] { "Id", "CreationTime", "CreatorId", "DeletionTime", "Icon", "IsDeleted", "Name", "Remark", "Type", "UserId" },
                values: new object[] { new Guid("58815bdd-614a-4d71-a1e0-d999c40479d0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "https://tokeniot.oss-cn-shenzhen.aliyuncs.com/icon/Dht.png", false, "温度计", "", 0, new Guid("4754a271-42d5-4e0d-8298-41b19dd00ab3") });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "Component", "ConcurrencyStamp", "CreationTime", "ExtraProperties", "Icon", "Index", "IsDeleted", "Name", "ParentId", "Path", "Title" },
                values: new object[,]
                {
                    { new Guid("044b20ff-34ed-432f-a61c-84f46f1f5cbf"), "@/pages/authority/menus/index", "227cb7998c7f4d178e0fa857d5e64ff1", new DateTime(2022, 9, 4, 23, 16, 51, 615, DateTimeKind.Local).AddTicks(3689), "{}", null, 2, false, "菜单管理", new Guid("f58d2feb-f9c7-4a5a-a761-78690fe3e895"), "/admin/authority/menu", "菜单管理" },
                    { new Guid("1d55c6a4-95ef-4ec7-924a-5f43a0dae42f"), "@/pages/devices/running-log/index", "2541dd6b6e0f47db86917db802146c56", new DateTime(2022, 9, 4, 23, 16, 51, 615, DateTimeKind.Local).AddTicks(3710), "{}", null, 1, false, "设备运行日志", new Guid("5ed82239-c2d3-4391-ab67-e752448f3816"), "/admin/devices/admin", "设备运行日志" },
                    { new Guid("4b3b6690-d5d6-4693-83f8-fb41c1c47bdb"), "@/pages/devices/template/index", "3a85f04cda0d49399c9bab7d9f3b345d", new DateTime(2022, 9, 4, 23, 16, 51, 615, DateTimeKind.Local).AddTicks(3702), "{}", null, 0, false, "设备模板", new Guid("5ed82239-c2d3-4391-ab67-e752448f3816"), "/admin/devices/template", "设备模板" },
                    { new Guid("5af12e31-2ce9-4160-84e0-c642b606e76d"), "@/pages/home/index", "eb465ace49a14e639b5a8fa6b615c2d2", new DateTime(2022, 9, 4, 23, 16, 51, 615, DateTimeKind.Local).AddTicks(3661), "{}", "HomeOutlined", 0, false, "首页", null, "/admin", "首页" },
                    { new Guid("5c1939e7-3143-4c6f-8489-5f05c4d5d938"), "@/pages/authority/users/index", "f1bf35c59fbf49199d3d85b1694640cb", new DateTime(2022, 9, 4, 23, 16, 51, 615, DateTimeKind.Local).AddTicks(3684), "{}", null, 1, false, "用户管理", new Guid("f58d2feb-f9c7-4a5a-a761-78690fe3e895"), "/admin/authority/user", "用户管理" },
                    { new Guid("5ed82239-c2d3-4391-ab67-e752448f3816"), null, "67fa0977e0f949b897ed874b5a886bca", new DateTime(2022, 9, 4, 23, 16, 51, 615, DateTimeKind.Local).AddTicks(3693), "{}", "DashboardOutlined", 2, false, "设备", null, "/admin/devices", "设备" },
                    { new Guid("b9a97cb5-3161-41fc-9d08-f1e2aebfbd2a"), "@/pages/authority/roles/index", "f6407f39e7f34fd097b823f871d78608", new DateTime(2022, 9, 4, 23, 16, 51, 615, DateTimeKind.Local).AddTicks(3676), "{}", null, 0, false, "角色管理", new Guid("f58d2feb-f9c7-4a5a-a761-78690fe3e895"), "/admin/authority/role", "角色管理" },
                    { new Guid("f58d2feb-f9c7-4a5a-a761-78690fe3e895"), "", "b0c9652638234eec87200ff38b53d939", new DateTime(2022, 9, 4, 23, 16, 51, 615, DateTimeKind.Local).AddTicks(3666), "{}", "SettingOutlined", 1, false, "权限管理", null, "/admin/authority", "权限管理" },
                    { new Guid("fcc79e87-cd8e-431c-b38f-3135fabff3e2"), "@/pages/devices/admin/index", "63df7f5b74324fffb90a891f5f766fb9", new DateTime(2022, 9, 4, 23, 16, 51, 615, DateTimeKind.Local).AddTicks(3714), "{}", null, 2, false, "设备管理", new Guid("5ed82239-c2d3-4391-ab67-e752448f3816"), "/admin/devices/admin", "设备管理" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Code", "ConcurrencyStamp", "CreationTime", "ExtraProperties", "Index", "IsDeleted", "Name", "ParentId", "Remark" },
                values: new object[] { new Guid("bcb5daa3-2cd0-4a89-958c-ce525688b791"), "admin", "e4f30f8cc16b4e8888a9ff5df7b00a8a", new DateTime(2022, 9, 4, 23, 16, 51, 615, DateTimeKind.Local).AddTicks(3561), "{}", 0, false, "管理员", null, "系统管理员" });

            migrationBuilder.InsertData(
                table: "IotDevices",
                columns: new[] { "Id", "CreationTime", "CreatorId", "DeletionTime", "DeviceTemplateId", "IsDeleted", "LastTime", "Name", "Remark", "Stats", "UserInfoId" },
                values: new object[] { new Guid("fee8dc18-d869-4e9a-b345-98fe148065ca"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("58815bdd-614a-4d71-a1e0-d999c40479d0"), false, null, null, "", 1, new Guid("4754a271-42d5-4e0d-8298-41b19dd00ab3") });

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
        }
    }
}
