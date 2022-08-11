using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Iot.EntityFrameworkCore.Dbmigrator.Migrations
{
    public partial class createuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IotUserInfo", x => x.Id);
                },
                comment: "用户信息");

            migrationBuilder.CreateTable(
                name: "IotDevices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stats = table.Column<int>(type: "int", nullable: false),
                    UserInfoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IotDevices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IotDevices_IotUserInfo_UserInfoId",
                        column: x => x.UserInfoId,
                        principalTable: "IotUserInfo",
                        principalColumn: "Id");
                },
                comment: "设备信息");

            migrationBuilder.CreateTable(
                name: "DHTLogs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DeviceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Logs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DHTLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DHTLogs_IotDevices_DeviceId",
                        column: x => x.DeviceId,
                        principalTable: "IotDevices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "DHT运行记录");

            migrationBuilder.InsertData(
                table: "IotUserInfo",
                columns: new[] { "Id", "AccountNumber", "Avatar", "ConcurrencyStamp", "DeletionTime", "Introduce", "IsDeleted", "Name", "Password", "PhoneNumber", "State", "WeChatOpenId" },
                values: new object[] { new Guid("b5c54e0c-ba91-4410-a5c2-2c1310d7a039"), "admin", "https://xiaohuchat.oss-cn-beijing.aliyuncs.com/ima/admin.jpg", "4e93c451da294215a8e5f6d74d949efb", null, "超级管理员", false, "管理员", "dd666666", "13049809673", 0, null });

            migrationBuilder.InsertData(
                table: "IotDevices",
                columns: new[] { "Id", "ConcurrencyStamp", "DeletionTime", "Icon", "IsDeleted", "Name", "Remark", "Stats", "Type", "UserInfoId" },
                values: new object[] { new Guid("2a2edae0-1f3c-4fec-90aa-63a6cabbf0ad"), "ce74f16e7c684bf391f5c3f41aa0795b", null, "https://tokeniot.oss-cn-shenzhen.aliyuncs.com/icon/Dht.png", false, "温度计", "", 1, 0, new Guid("b5c54e0c-ba91-4410-a5c2-2c1310d7a039") });

            migrationBuilder.CreateIndex(
                name: "IX_DHTLogs_DeviceId",
                table: "DHTLogs",
                column: "DeviceId");

            migrationBuilder.CreateIndex(
                name: "IX_DHTLogs_Id",
                table: "DHTLogs",
                column: "Id");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DHTLogs");

            migrationBuilder.DropTable(
                name: "IotDevices");

            migrationBuilder.DropTable(
                name: "IotUserInfo");
        }
    }
}
