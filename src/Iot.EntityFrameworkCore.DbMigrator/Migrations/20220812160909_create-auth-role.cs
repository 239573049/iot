using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Iot.EntityFrameworkCore.Dbmigrator.Migrations
{
    public partial class createauthrole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IotDevices",
                keyColumn: "Id",
                keyValue: new Guid("2a2edae0-1f3c-4fec-90aa-63a6cabbf0ad"));

            migrationBuilder.DeleteData(
                table: "IotUserInfo",
                keyColumn: "Id",
                keyValue: new Guid("b5c54e0c-ba91-4410-a5c2-2c1310d7a039"));

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
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                },
                comment: "角色");

            migrationBuilder.CreateTable(
                name: "menuRoleFunctions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MenuId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_menuRoleFunctions", x => x.Id);
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserInfoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoleFunctions", x => x.Id);
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

            migrationBuilder.InsertData(
                table: "IotUserInfo",
                columns: new[] { "Id", "AccountNumber", "Avatar", "ConcurrencyStamp", "DeletionTime", "Introduce", "IsDeleted", "Name", "Password", "PhoneNumber", "State", "WeChatOpenId" },
                values: new object[] { new Guid("7df41acd-c9ff-4f63-8c68-43c4b4ed1d1d"), "admin", "https://xiaohuchat.oss-cn-beijing.aliyuncs.com/ima/admin.jpg", "8f6db9de7bb249d8bac28a81bf0eed1f", null, "超级管理员", false, "管理员", "dd666666", "13049809673", 0, null });

            migrationBuilder.InsertData(
                table: "IotDevices",
                columns: new[] { "Id", "ConcurrencyStamp", "DeletionTime", "Icon", "IsDeleted", "Name", "Remark", "Stats", "Type", "UserInfoId" },
                values: new object[] { new Guid("5692e070-7613-40c2-8c37-5bf28cf0d82d"), "b2806e929d734c6991ca3af548d8b0a8", null, "https://tokeniot.oss-cn-shenzhen.aliyuncs.com/icon/Dht.png", false, "温度计", "", 1, 0, new Guid("7df41acd-c9ff-4f63-8c68-43c4b4ed1d1d") });

            migrationBuilder.CreateIndex(
                name: "IX_menuRoleFunctions_Id",
                table: "menuRoleFunctions",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_menuRoleFunctions_MenuId",
                table: "menuRoleFunctions",
                column: "MenuId");

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
                name: "IX_UserRoleFunctions_Id",
                table: "UserRoleFunctions",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoleFunctions_RoleId",
                table: "UserRoleFunctions",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoleFunctions_UserInfoId",
                table: "UserRoleFunctions",
                column: "UserInfoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "menuRoleFunctions");

            migrationBuilder.DropTable(
                name: "UserRoleFunctions");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DeleteData(
                table: "IotDevices",
                keyColumn: "Id",
                keyValue: new Guid("5692e070-7613-40c2-8c37-5bf28cf0d82d"));

            migrationBuilder.DeleteData(
                table: "IotUserInfo",
                keyColumn: "Id",
                keyValue: new Guid("7df41acd-c9ff-4f63-8c68-43c4b4ed1d1d"));

            migrationBuilder.InsertData(
                table: "IotUserInfo",
                columns: new[] { "Id", "AccountNumber", "Avatar", "ConcurrencyStamp", "DeletionTime", "Introduce", "IsDeleted", "Name", "Password", "PhoneNumber", "State", "WeChatOpenId" },
                values: new object[] { new Guid("b5c54e0c-ba91-4410-a5c2-2c1310d7a039"), "admin", "https://xiaohuchat.oss-cn-beijing.aliyuncs.com/ima/admin.jpg", "4e93c451da294215a8e5f6d74d949efb", null, "超级管理员", false, "管理员", "dd666666", "13049809673", 0, null });

            migrationBuilder.InsertData(
                table: "IotDevices",
                columns: new[] { "Id", "ConcurrencyStamp", "DeletionTime", "Icon", "IsDeleted", "Name", "Remark", "Stats", "Type", "UserInfoId" },
                values: new object[] { new Guid("2a2edae0-1f3c-4fec-90aa-63a6cabbf0ad"), "ce74f16e7c684bf391f5c3f41aa0795b", null, "https://tokeniot.oss-cn-shenzhen.aliyuncs.com/icon/Dht.png", false, "温度计", "", 1, 0, new Guid("b5c54e0c-ba91-4410-a5c2-2c1310d7a039") });
        }
    }
}
