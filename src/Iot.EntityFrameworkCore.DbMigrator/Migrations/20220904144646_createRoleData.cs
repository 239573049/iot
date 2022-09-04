using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Iot.EntityFrameworkCore.Dbmigrator.Migrations
{
    public partial class createRoleData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRoleFunctions",
                table: "UserRoleFunctions");

            migrationBuilder.DropIndex(
                name: "IX_UserRoleFunctions_Id",
                table: "UserRoleFunctions");

            migrationBuilder.DropIndex(
                name: "IX_UserRoleFunctions_UserInfoId",
                table: "UserRoleFunctions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_menuRoleFunctions",
                table: "menuRoleFunctions");

            migrationBuilder.DropIndex(
                name: "IX_menuRoleFunctions_Id",
                table: "menuRoleFunctions");

            migrationBuilder.DropIndex(
                name: "IX_menuRoleFunctions_MenuId",
                table: "menuRoleFunctions");

            migrationBuilder.DeleteData(
                table: "IotDevices",
                keyColumn: "Id",
                keyValue: new Guid("1c53df06-641c-4125-97dd-b10ebcc22fbc"));

            migrationBuilder.DeleteData(
                table: "DeviceTemplates",
                keyColumn: "Id",
                keyValue: new Guid("a6c44d61-f63e-4775-b763-9b2abfdc283f"));

            migrationBuilder.DeleteData(
                table: "IotUserInfo",
                keyColumn: "Id",
                keyValue: new Guid("7f730715-c83e-4998-ac60-fb326e769bf2"));

            migrationBuilder.DropColumn(
                name: "Id",
                table: "UserRoleFunctions");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "UserRoleFunctions");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "menuRoleFunctions");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "menuRoleFunctions");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Roles",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "ConcurrencyStamp",
                table: "Roles",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExtraProperties",
                table: "Roles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Menus",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "ConcurrencyStamp",
                table: "Menus",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Menus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ExtraProperties",
                table: "Menus",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRoleFunctions",
                table: "UserRoleFunctions",
                columns: new[] { "UserInfoId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_menuRoleFunctions",
                table: "menuRoleFunctions",
                columns: new[] { "MenuId", "RoleId" });

            migrationBuilder.InsertData(
                table: "IotUserInfo",
                columns: new[] { "Id", "AccountNumber", "Avatar", "CreationTime", "CreatorId", "DeletionTime", "Introduce", "Name", "Password", "PhoneNumber", "State", "WeChatOpenId" },
                values: new object[] { new Guid("8749ca90-555c-4b4a-b974-c520b5b4766a"), "admin", "https://xiaohuchat.oss-cn-beijing.aliyuncs.com/ima/admin.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "超级管理员", "管理员", "dd666666", "13049809673", 0, null });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "Component", "ConcurrencyStamp", "CreationTime", "ExtraProperties", "Icon", "Index", "Name", "ParentId", "Path", "Title" },
                values: new object[,]
                {
                    { new Guid("02256adc-9797-4a82-836e-50119661662b"), "@/pages/authority/users/index", "a9f4f7939ad04ca08c169840abb08576", new DateTime(2022, 9, 4, 22, 46, 46, 374, DateTimeKind.Local).AddTicks(1189), "{}", null, 1, "用户管理", new Guid("bb72fac0-1d4f-408b-b7e6-248594514f38"), "/authority/user", "用户管理" },
                    { new Guid("417e578a-48fe-41b6-a60d-21cffbd99328"), null, "11d03668a9dc4cacb00dc19f3787b27d", new DateTime(2022, 9, 4, 22, 46, 46, 374, DateTimeKind.Local).AddTicks(1197), "{}", "DashboardOutlined", 2, "设备", null, "/devices", "设备" },
                    { new Guid("67a38722-ad2b-4693-b767-1a8bbd026a7f"), "@/pages/devices/template/index", "66c4de51e2f1470588f80d8bfe6966fb", new DateTime(2022, 9, 4, 22, 46, 46, 374, DateTimeKind.Local).AddTicks(1203), "{}", null, 0, "设备模板", new Guid("417e578a-48fe-41b6-a60d-21cffbd99328"), "/devices/template", "设备模板" },
                    { new Guid("72745051-a07d-4d9e-8fcb-8b3188040b5a"), "@/pages/home/index", "38fa5f7cfed34da9a7c8540f1d9f4d4f", new DateTime(2022, 9, 4, 22, 46, 46, 374, DateTimeKind.Local).AddTicks(1170), "{}", "HomeOutlined", 0, "首页", null, "/", "首页" },
                    { new Guid("98c36e51-4b78-4690-b170-68e14304f0ae"), "@/pages/devices/admin/index", "d9f7a17c1c734c549b8726aa24bdf270", new DateTime(2022, 9, 4, 22, 46, 46, 374, DateTimeKind.Local).AddTicks(1207), "{}", null, 1, "设备管理", new Guid("417e578a-48fe-41b6-a60d-21cffbd99328"), "/devices/admin", "设备管理" },
                    { new Guid("af0a92e5-86ed-4d57-905f-c9765e5e0f9e"), "@/pages/authority/roles/index", "1604c7258daf48929c138377aa5855d7", new DateTime(2022, 9, 4, 22, 46, 46, 374, DateTimeKind.Local).AddTicks(1185), "{}", null, 0, "角色管理", new Guid("bb72fac0-1d4f-408b-b7e6-248594514f38"), "/authority/role", "角色管理" },
                    { new Guid("bb72fac0-1d4f-408b-b7e6-248594514f38"), "", "003f71409f6f43c8bff3eacfb4f09d13", new DateTime(2022, 9, 4, 22, 46, 46, 374, DateTimeKind.Local).AddTicks(1175), "{}", "SettingOutlined", 1, "权限管理", null, "/authority", "权限管理" },
                    { new Guid("efca255d-bbc2-46d4-a28f-6b9f8b35a617"), "@/pages/authority/menus/index", "f8766a897e344567a34fa293606be746", new DateTime(2022, 9, 4, 22, 46, 46, 374, DateTimeKind.Local).AddTicks(1193), "{}", null, 2, "菜单管理", new Guid("bb72fac0-1d4f-408b-b7e6-248594514f38"), "/authority/menu", "菜单管理" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Code", "ConcurrencyStamp", "CreationTime", "ExtraProperties", "Index", "Name", "ParentId", "Remark" },
                values: new object[] { new Guid("e1d3806f-a432-4e38-91e0-6823148e0ed2"), "admin", "cf04189a00a64a50b50fd6293b09169d", new DateTime(2022, 9, 4, 22, 46, 46, 374, DateTimeKind.Local).AddTicks(1094), "{}", 0, "管理员", null, "系统管理员" });

            migrationBuilder.InsertData(
                table: "DeviceTemplates",
                columns: new[] { "Id", "CreationTime", "CreatorId", "DeletionTime", "Icon", "Name", "Remark", "Type", "UserId" },
                values: new object[] { new Guid("45784583-83f4-40ea-a95e-19ddb411fe3b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "https://tokeniot.oss-cn-shenzhen.aliyuncs.com/icon/Dht.png", "温度计", "", 0, new Guid("8749ca90-555c-4b4a-b974-c520b5b4766a") });

            migrationBuilder.InsertData(
                table: "IotDevices",
                columns: new[] { "Id", "CreationTime", "CreatorId", "DeletionTime", "DeviceTemplateId", "LastTime", "Name", "Remark", "Stats", "UserInfoId" },
                values: new object[] { new Guid("3ec20660-d276-40f1-bcca-f446207356ca"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("45784583-83f4-40ea-a95e-19ddb411fe3b"), null, null, "", 1, new Guid("8749ca90-555c-4b4a-b974-c520b5b4766a") });

            migrationBuilder.CreateIndex(
                name: "IX_UserRoleFunctions_UserInfoId_RoleId",
                table: "UserRoleFunctions",
                columns: new[] { "UserInfoId", "RoleId" });

            migrationBuilder.CreateIndex(
                name: "IX_menuRoleFunctions_MenuId_RoleId",
                table: "menuRoleFunctions",
                columns: new[] { "MenuId", "RoleId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRoleFunctions",
                table: "UserRoleFunctions");

            migrationBuilder.DropIndex(
                name: "IX_UserRoleFunctions_UserInfoId_RoleId",
                table: "UserRoleFunctions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_menuRoleFunctions",
                table: "menuRoleFunctions");

            migrationBuilder.DropIndex(
                name: "IX_menuRoleFunctions_MenuId_RoleId",
                table: "menuRoleFunctions");

            migrationBuilder.DeleteData(
                table: "IotDevices",
                keyColumn: "Id",
                keyValue: new Guid("3ec20660-d276-40f1-bcca-f446207356ca"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("02256adc-9797-4a82-836e-50119661662b"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("417e578a-48fe-41b6-a60d-21cffbd99328"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("67a38722-ad2b-4693-b767-1a8bbd026a7f"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("72745051-a07d-4d9e-8fcb-8b3188040b5a"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("98c36e51-4b78-4690-b170-68e14304f0ae"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("af0a92e5-86ed-4d57-905f-c9765e5e0f9e"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("bb72fac0-1d4f-408b-b7e6-248594514f38"));

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: new Guid("efca255d-bbc2-46d4-a28f-6b9f8b35a617"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e1d3806f-a432-4e38-91e0-6823148e0ed2"));

            migrationBuilder.DeleteData(
                table: "DeviceTemplates",
                keyColumn: "Id",
                keyValue: new Guid("45784583-83f4-40ea-a95e-19ddb411fe3b"));

            migrationBuilder.DeleteData(
                table: "IotUserInfo",
                keyColumn: "Id",
                keyValue: new Guid("8749ca90-555c-4b4a-b974-c520b5b4766a"));

            migrationBuilder.DropColumn(
                name: "ExtraProperties",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "ExtraProperties",
                table: "Menus");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "UserRoleFunctions",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "UserRoleFunctions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Roles",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "ConcurrencyStamp",
                table: "Roles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "Menus",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "ConcurrencyStamp",
                table: "Menus",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40,
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "menuRoleFunctions",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "menuRoleFunctions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRoleFunctions",
                table: "UserRoleFunctions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_menuRoleFunctions",
                table: "menuRoleFunctions",
                column: "Id");

            migrationBuilder.InsertData(
                table: "IotUserInfo",
                columns: new[] { "Id", "AccountNumber", "Avatar", "CreationTime", "CreatorId", "DeletionTime", "Introduce", "IsDeleted", "Name", "Password", "PhoneNumber", "State", "WeChatOpenId" },
                values: new object[] { new Guid("7f730715-c83e-4998-ac60-fb326e769bf2"), "admin", "https://xiaohuchat.oss-cn-beijing.aliyuncs.com/ima/admin.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "超级管理员", false, "管理员", "dd666666", "13049809673", 0, null });

            migrationBuilder.InsertData(
                table: "DeviceTemplates",
                columns: new[] { "Id", "CreationTime", "CreatorId", "DeletionTime", "Icon", "IsDeleted", "Name", "Remark", "Type", "UserId" },
                values: new object[] { new Guid("a6c44d61-f63e-4775-b763-9b2abfdc283f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "https://tokeniot.oss-cn-shenzhen.aliyuncs.com/icon/Dht.png", false, "温度计", "", 0, new Guid("7f730715-c83e-4998-ac60-fb326e769bf2") });

            migrationBuilder.InsertData(
                table: "IotDevices",
                columns: new[] { "Id", "CreationTime", "CreatorId", "DeletionTime", "DeviceTemplateId", "IsDeleted", "LastTime", "Name", "Remark", "Stats", "UserInfoId" },
                values: new object[] { new Guid("1c53df06-641c-4125-97dd-b10ebcc22fbc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new Guid("a6c44d61-f63e-4775-b763-9b2abfdc283f"), false, null, null, "", 1, new Guid("7f730715-c83e-4998-ac60-fb326e769bf2") });

            migrationBuilder.CreateIndex(
                name: "IX_UserRoleFunctions_Id",
                table: "UserRoleFunctions",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoleFunctions_UserInfoId",
                table: "UserRoleFunctions",
                column: "UserInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_menuRoleFunctions_Id",
                table: "menuRoleFunctions",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_menuRoleFunctions_MenuId",
                table: "menuRoleFunctions",
                column: "MenuId");
        }
    }
}
