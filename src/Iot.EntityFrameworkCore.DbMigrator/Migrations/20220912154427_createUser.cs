using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Iot.EntityFrameworkCore.Dbmigrator.Migrations
{
    public partial class createUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRoleFunctions",
                keyColumns: new[] { "RoleId", "UserInfoId" },
                keyValues: new object[] { new Guid("bb177f9b-56b0-4178-a94e-ccd3fa079f19"), new Guid("4754a271-42d5-4e0d-8298-41b19dd00ab3") });

            migrationBuilder.DeleteData(
                table: "menuRoleFunctions",
                keyColumns: new[] { "MenuId", "RoleId" },
                keyValues: new object[] { new Guid("08fa9278-5395-4a53-bf27-4b46bff2b6d5"), new Guid("bb177f9b-56b0-4178-a94e-ccd3fa079f19") });

            migrationBuilder.DeleteData(
                table: "menuRoleFunctions",
                keyColumns: new[] { "MenuId", "RoleId" },
                keyValues: new object[] { new Guid("11fac735-390c-4d1b-b299-950561216851"), new Guid("bb177f9b-56b0-4178-a94e-ccd3fa079f19") });

            migrationBuilder.DeleteData(
                table: "menuRoleFunctions",
                keyColumns: new[] { "MenuId", "RoleId" },
                keyValues: new object[] { new Guid("239b8ff3-81f1-4f62-91dd-558f4630b8ef"), new Guid("bb177f9b-56b0-4178-a94e-ccd3fa079f19") });

            migrationBuilder.DeleteData(
                table: "menuRoleFunctions",
                keyColumns: new[] { "MenuId", "RoleId" },
                keyValues: new object[] { new Guid("49a2f53e-7034-4823-ab75-cc7da17c6f81"), new Guid("bb177f9b-56b0-4178-a94e-ccd3fa079f19") });

            migrationBuilder.DeleteData(
                table: "menuRoleFunctions",
                keyColumns: new[] { "MenuId", "RoleId" },
                keyValues: new object[] { new Guid("573b7241-38f5-4198-84a9-93a5f673540e"), new Guid("bb177f9b-56b0-4178-a94e-ccd3fa079f19") });

            migrationBuilder.DeleteData(
                table: "menuRoleFunctions",
                keyColumns: new[] { "MenuId", "RoleId" },
                keyValues: new object[] { new Guid("ab874e3b-efeb-4c52-ac14-7b22a8a93bf8"), new Guid("bb177f9b-56b0-4178-a94e-ccd3fa079f19") });

            migrationBuilder.DeleteData(
                table: "menuRoleFunctions",
                keyColumns: new[] { "MenuId", "RoleId" },
                keyValues: new object[] { new Guid("b6f60ec6-e522-4c09-8645-94fea2b870ae"), new Guid("bb177f9b-56b0-4178-a94e-ccd3fa079f19") });

            migrationBuilder.DeleteData(
                table: "menuRoleFunctions",
                keyColumns: new[] { "MenuId", "RoleId" },
                keyValues: new object[] { new Guid("cfbf0046-d5e3-4a25-bbe2-6896fb4bfb67"), new Guid("bb177f9b-56b0-4178-a94e-ccd3fa079f19") });

            migrationBuilder.DeleteData(
                table: "menuRoleFunctions",
                keyColumns: new[] { "MenuId", "RoleId" },
                keyValues: new object[] { new Guid("f2f49534-4dc7-4867-9629-468b73dacb8b"), new Guid("bb177f9b-56b0-4178-a94e-ccd3fa079f19") });

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("08fa9278-5395-4a53-bf27-4b46bff2b6d5"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("11fac735-390c-4d1b-b299-950561216851"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("239b8ff3-81f1-4f62-91dd-558f4630b8ef"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("49a2f53e-7034-4823-ab75-cc7da17c6f81"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("573b7241-38f5-4198-84a9-93a5f673540e"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("ab874e3b-efeb-4c52-ac14-7b22a8a93bf8"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("b6f60ec6-e522-4c09-8645-94fea2b870ae"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("cfbf0046-d5e3-4a25-bbe2-6896fb4bfb67"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("f2f49534-4dc7-4867-9629-468b73dacb8b"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("bb177f9b-56b0-4178-a94e-ccd3fa079f19"));

            migrationBuilder.InsertData(
                table: "IotUserInfo",
                columns: new[] { "Id", "AccountNumber", "Avatar", "CreationTime", "CreatorId", "DeletionTime", "Introduce", "Name", "Password", "PhoneNumber", "State", "WeChatOpenId" },
                values: new object[] { new Guid("4754a271-42d5-4e0d-8298-41b19dd00ab3"), "admin", "https://xiaohuchat.oss-cn-beijing.aliyuncs.com/ima/admin.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "超级管理员", "管理员", "dd666666", "13049809673", 0, null });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "Component", "ConcurrencyStamp", "CreationTime", "ExtraProperties", "Icon", "Index", "Name", "ParentId", "Path", "Title" },
                values: new object[,]
                {
                    { new Guid("0c3d278a-361e-4432-8b7b-014131c1469a"), "@/pages/devices/admin/index", "df21e3b2731743d1a65f38bb7c1e60f2", new DateTime(2022, 9, 12, 23, 44, 27, 359, DateTimeKind.Local).AddTicks(569), "{}", null, 2, "设备管理", new Guid("6e06b631-b9c4-4b55-a51c-a4d4e0445489"), "/devices/admin", "设备管理" },
                    { new Guid("0c910427-8cc9-43a7-a858-47a621ef10b6"), "@/pages/home/index", "38f55aea074d43daa96db327b82780c2", new DateTime(2022, 9, 12, 23, 44, 27, 359, DateTimeKind.Local).AddTicks(533), "{}", "HomeOutlined", 0, "首页", null, "/admin", "首页" },
                    { new Guid("15128746-57a8-4b11-8277-d569b5b75b6e"), "", "167086df923a468aaaf2b457df4453ab", new DateTime(2022, 9, 12, 23, 44, 27, 359, DateTimeKind.Local).AddTicks(538), "{}", "SettingOutlined", 1, "权限管理", null, "/authority", "权限管理" },
                    { new Guid("1c635748-1356-49e3-864d-988e9314fc2e"), "@/pages/authority/menus/index", "c982872fbfa34f2483271c37f6ac1611", new DateTime(2022, 9, 12, 23, 44, 27, 359, DateTimeKind.Local).AddTicks(552), "{}", null, 2, "菜单管理", new Guid("15128746-57a8-4b11-8277-d569b5b75b6e"), "/authority/menu", "菜单管理" },
                    { new Guid("407c09a8-9fd5-43ab-a997-1b2f991f4dc4"), "@/pages/devices/template/index", "a2962eab14894040b510499bc933986b", new DateTime(2022, 9, 12, 23, 44, 27, 359, DateTimeKind.Local).AddTicks(559), "{}", null, 0, "设备模板", new Guid("6e06b631-b9c4-4b55-a51c-a4d4e0445489"), "/devices/template", "设备模板" },
                    { new Guid("5b543c93-79ea-48b7-80b0-c0afb7d711dd"), "@/pages/authority/roles/index", "60ee635496d643a4a2c65564bc615e35", new DateTime(2022, 9, 12, 23, 44, 27, 359, DateTimeKind.Local).AddTicks(542), "{}", null, 0, "角色管理", new Guid("15128746-57a8-4b11-8277-d569b5b75b6e"), "/authority/role", "角色管理" },
                    { new Guid("6e06b631-b9c4-4b55-a51c-a4d4e0445489"), null, "565ebc19823f4ed6b728d0b61c04d60d", new DateTime(2022, 9, 12, 23, 44, 27, 359, DateTimeKind.Local).AddTicks(556), "{}", "DashboardOutlined", 2, "设备", null, "/devices", "设备" },
                    { new Guid("c7887295-3787-46a2-bc48-b370e5f5a3b1"), "@/pages/devices/running-log/index", "48312c1a7d094636aa151c381623f702", new DateTime(2022, 9, 12, 23, 44, 27, 359, DateTimeKind.Local).AddTicks(565), "{}", null, 1, "设备运行日志", new Guid("6e06b631-b9c4-4b55-a51c-a4d4e0445489"), "/devices/running-log", "设备运行日志" },
                    { new Guid("d2477d81-2a9e-42e3-806d-4f76e927e07d"), "@/pages/authority/users/index", "4b9e0700bd17469493e593771ce096a1", new DateTime(2022, 9, 12, 23, 44, 27, 359, DateTimeKind.Local).AddTicks(549), "{}", null, 1, "用户管理", new Guid("15128746-57a8-4b11-8277-d569b5b75b6e"), "/authority/user", "用户管理" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Code", "ConcurrencyStamp", "CreationTime", "ExtraProperties", "Index", "Name", "ParentId", "Remark" },
                values: new object[] { new Guid("fc6fc3f6-ca81-4df1-ae3c-2a199178f7d1"), "admin", "14a42a8af7ff43039cfab1cc444000c2", new DateTime(2022, 9, 12, 23, 44, 27, 359, DateTimeKind.Local).AddTicks(447), "{}", 0, "管理员", null, "系统管理员" });

            migrationBuilder.InsertData(
                table: "UserRoleFunctions",
                columns: new[] { "RoleId", "UserInfoId" },
                values: new object[] { new Guid("fc6fc3f6-ca81-4df1-ae3c-2a199178f7d1"), new Guid("4754a271-42d5-4e0d-8298-41b19dd00ab3") });

            migrationBuilder.InsertData(
                table: "menuRoleFunctions",
                columns: new[] { "MenuId", "RoleId" },
                values: new object[,]
                {
                    { new Guid("0c3d278a-361e-4432-8b7b-014131c1469a"), new Guid("fc6fc3f6-ca81-4df1-ae3c-2a199178f7d1") },
                    { new Guid("0c910427-8cc9-43a7-a858-47a621ef10b6"), new Guid("fc6fc3f6-ca81-4df1-ae3c-2a199178f7d1") },
                    { new Guid("15128746-57a8-4b11-8277-d569b5b75b6e"), new Guid("fc6fc3f6-ca81-4df1-ae3c-2a199178f7d1") },
                    { new Guid("1c635748-1356-49e3-864d-988e9314fc2e"), new Guid("fc6fc3f6-ca81-4df1-ae3c-2a199178f7d1") },
                    { new Guid("407c09a8-9fd5-43ab-a997-1b2f991f4dc4"), new Guid("fc6fc3f6-ca81-4df1-ae3c-2a199178f7d1") },
                    { new Guid("5b543c93-79ea-48b7-80b0-c0afb7d711dd"), new Guid("fc6fc3f6-ca81-4df1-ae3c-2a199178f7d1") },
                    { new Guid("6e06b631-b9c4-4b55-a51c-a4d4e0445489"), new Guid("fc6fc3f6-ca81-4df1-ae3c-2a199178f7d1") },
                    { new Guid("c7887295-3787-46a2-bc48-b370e5f5a3b1"), new Guid("fc6fc3f6-ca81-4df1-ae3c-2a199178f7d1") },
                    { new Guid("d2477d81-2a9e-42e3-806d-4f76e927e07d"), new Guid("fc6fc3f6-ca81-4df1-ae3c-2a199178f7d1") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IotUserInfo",
                keyColumn: "Id",
                keyValue: new Guid("4754a271-42d5-4e0d-8298-41b19dd00ab3"));

            migrationBuilder.DeleteData(
                table: "UserRoleFunctions",
                keyColumns: new[] { "RoleId", "UserInfoId" },
                keyValues: new object[] { new Guid("fc6fc3f6-ca81-4df1-ae3c-2a199178f7d1"), new Guid("4754a271-42d5-4e0d-8298-41b19dd00ab3") });

            migrationBuilder.DeleteData(
                table: "menuRoleFunctions",
                keyColumns: new[] { "MenuId", "RoleId" },
                keyValues: new object[] { new Guid("0c3d278a-361e-4432-8b7b-014131c1469a"), new Guid("fc6fc3f6-ca81-4df1-ae3c-2a199178f7d1") });

            migrationBuilder.DeleteData(
                table: "menuRoleFunctions",
                keyColumns: new[] { "MenuId", "RoleId" },
                keyValues: new object[] { new Guid("0c910427-8cc9-43a7-a858-47a621ef10b6"), new Guid("fc6fc3f6-ca81-4df1-ae3c-2a199178f7d1") });

            migrationBuilder.DeleteData(
                table: "menuRoleFunctions",
                keyColumns: new[] { "MenuId", "RoleId" },
                keyValues: new object[] { new Guid("15128746-57a8-4b11-8277-d569b5b75b6e"), new Guid("fc6fc3f6-ca81-4df1-ae3c-2a199178f7d1") });

            migrationBuilder.DeleteData(
                table: "menuRoleFunctions",
                keyColumns: new[] { "MenuId", "RoleId" },
                keyValues: new object[] { new Guid("1c635748-1356-49e3-864d-988e9314fc2e"), new Guid("fc6fc3f6-ca81-4df1-ae3c-2a199178f7d1") });

            migrationBuilder.DeleteData(
                table: "menuRoleFunctions",
                keyColumns: new[] { "MenuId", "RoleId" },
                keyValues: new object[] { new Guid("407c09a8-9fd5-43ab-a997-1b2f991f4dc4"), new Guid("fc6fc3f6-ca81-4df1-ae3c-2a199178f7d1") });

            migrationBuilder.DeleteData(
                table: "menuRoleFunctions",
                keyColumns: new[] { "MenuId", "RoleId" },
                keyValues: new object[] { new Guid("5b543c93-79ea-48b7-80b0-c0afb7d711dd"), new Guid("fc6fc3f6-ca81-4df1-ae3c-2a199178f7d1") });

            migrationBuilder.DeleteData(
                table: "menuRoleFunctions",
                keyColumns: new[] { "MenuId", "RoleId" },
                keyValues: new object[] { new Guid("6e06b631-b9c4-4b55-a51c-a4d4e0445489"), new Guid("fc6fc3f6-ca81-4df1-ae3c-2a199178f7d1") });

            migrationBuilder.DeleteData(
                table: "menuRoleFunctions",
                keyColumns: new[] { "MenuId", "RoleId" },
                keyValues: new object[] { new Guid("c7887295-3787-46a2-bc48-b370e5f5a3b1"), new Guid("fc6fc3f6-ca81-4df1-ae3c-2a199178f7d1") });

            migrationBuilder.DeleteData(
                table: "menuRoleFunctions",
                keyColumns: new[] { "MenuId", "RoleId" },
                keyValues: new object[] { new Guid("d2477d81-2a9e-42e3-806d-4f76e927e07d"), new Guid("fc6fc3f6-ca81-4df1-ae3c-2a199178f7d1") });

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("0c3d278a-361e-4432-8b7b-014131c1469a"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("0c910427-8cc9-43a7-a858-47a621ef10b6"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("15128746-57a8-4b11-8277-d569b5b75b6e"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("1c635748-1356-49e3-864d-988e9314fc2e"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("407c09a8-9fd5-43ab-a997-1b2f991f4dc4"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("5b543c93-79ea-48b7-80b0-c0afb7d711dd"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("6e06b631-b9c4-4b55-a51c-a4d4e0445489"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("c7887295-3787-46a2-bc48-b370e5f5a3b1"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("d2477d81-2a9e-42e3-806d-4f76e927e07d"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("fc6fc3f6-ca81-4df1-ae3c-2a199178f7d1"));

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "Component", "ConcurrencyStamp", "CreationTime", "ExtraProperties", "Icon", "Index", "IsDeleted", "Name", "ParentId", "Path", "Title" },
                values: new object[,]
                {
                    { new Guid("08fa9278-5395-4a53-bf27-4b46bff2b6d5"), "@/pages/devices/admin/index", "afab3e556cc3486db6020ee65e793429", new DateTime(2022, 9, 12, 23, 35, 37, 436, DateTimeKind.Local).AddTicks(5781), "{}", null, 2, false, "设备管理", new Guid("573b7241-38f5-4198-84a9-93a5f673540e"), "/devices/admin", "设备管理" },
                    { new Guid("11fac735-390c-4d1b-b299-950561216851"), "@/pages/devices/template/index", "6502bfc715664560abf18c4bf05aa867", new DateTime(2022, 9, 12, 23, 35, 37, 436, DateTimeKind.Local).AddTicks(5766), "{}", null, 0, false, "设备模板", new Guid("573b7241-38f5-4198-84a9-93a5f673540e"), "/devices/template", "设备模板" },
                    { new Guid("239b8ff3-81f1-4f62-91dd-558f4630b8ef"), "@/pages/home/index", "00aad36f432847f08344396693199b12", new DateTime(2022, 9, 12, 23, 35, 37, 436, DateTimeKind.Local).AddTicks(5729), "{}", "HomeOutlined", 0, false, "首页", null, "/admin", "首页" },
                    { new Guid("49a2f53e-7034-4823-ab75-cc7da17c6f81"), "@/pages/devices/running-log/index", "8029966ed10249deb4face7ce239ff5b", new DateTime(2022, 9, 12, 23, 35, 37, 436, DateTimeKind.Local).AddTicks(5777), "{}", null, 1, false, "设备运行日志", new Guid("573b7241-38f5-4198-84a9-93a5f673540e"), "/devices/running-log", "设备运行日志" },
                    { new Guid("573b7241-38f5-4198-84a9-93a5f673540e"), null, "55a4820cdeb545b68db8b4684db05a98", new DateTime(2022, 9, 12, 23, 35, 37, 436, DateTimeKind.Local).AddTicks(5761), "{}", "DashboardOutlined", 2, false, "设备", null, "/devices", "设备" },
                    { new Guid("ab874e3b-efeb-4c52-ac14-7b22a8a93bf8"), "@/pages/authority/users/index", "f8ccc83c75e24f81bf14fdd7fb7a4386", new DateTime(2022, 9, 12, 23, 35, 37, 436, DateTimeKind.Local).AddTicks(5752), "{}", null, 1, false, "用户管理", new Guid("cfbf0046-d5e3-4a25-bbe2-6896fb4bfb67"), "/authority/user", "用户管理" },
                    { new Guid("b6f60ec6-e522-4c09-8645-94fea2b870ae"), "@/pages/authority/roles/index", "48a8215c02d04fc792ebabf8a3f6822e", new DateTime(2022, 9, 12, 23, 35, 37, 436, DateTimeKind.Local).AddTicks(5747), "{}", null, 0, false, "角色管理", new Guid("cfbf0046-d5e3-4a25-bbe2-6896fb4bfb67"), "/authority/role", "角色管理" },
                    { new Guid("cfbf0046-d5e3-4a25-bbe2-6896fb4bfb67"), "", "b2cebf0f99964dfa9bbbc46cac491542", new DateTime(2022, 9, 12, 23, 35, 37, 436, DateTimeKind.Local).AddTicks(5742), "{}", "SettingOutlined", 1, false, "权限管理", null, "/authority", "权限管理" },
                    { new Guid("f2f49534-4dc7-4867-9629-468b73dacb8b"), "@/pages/authority/menus/index", "c6170945cd5a4be18f508ec3d86d9969", new DateTime(2022, 9, 12, 23, 35, 37, 436, DateTimeKind.Local).AddTicks(5756), "{}", null, 2, false, "菜单管理", new Guid("cfbf0046-d5e3-4a25-bbe2-6896fb4bfb67"), "/authority/menu", "菜单管理" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Code", "ConcurrencyStamp", "CreationTime", "ExtraProperties", "Index", "IsDeleted", "Name", "ParentId", "Remark" },
                values: new object[] { new Guid("bb177f9b-56b0-4178-a94e-ccd3fa079f19"), "admin", "a4e7ec82a2004f6d9cc2d642253dd214", new DateTime(2022, 9, 12, 23, 35, 37, 436, DateTimeKind.Local).AddTicks(5583), "{}", 0, false, "管理员", null, "系统管理员" });

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
        }
    }
}
