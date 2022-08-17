using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Iot.EntityFrameworkCore.Dbmigrator.Migrations
{
    public partial class logcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IotDevices",
                keyColumn: "Id",
                keyValue: new Guid("0ac57608-7cf8-40fe-90c0-56700ac2798e"));

            migrationBuilder.DeleteData(
                table: "IotUserInfo",
                keyColumn: "Id",
                keyValue: new Guid("f2128057-61c5-4b0a-9a26-b0af8f31cb26"));

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "IotUserInfo");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "IotDevices");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "DHTLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "IotUserInfo",
                columns: new[] { "Id", "AccountNumber", "Avatar", "CreationTime", "CreatorId", "DeletionTime", "Introduce", "IsDeleted", "Name", "Password", "PhoneNumber", "State", "WeChatOpenId" },
                values: new object[] { new Guid("304e5cb4-cb63-4c45-a834-8cd43ea55c7e"), "admin", "https://xiaohuchat.oss-cn-beijing.aliyuncs.com/ima/admin.jpg", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "超级管理员", false, "管理员", "dd666666", "13049809673", 0, null });

            migrationBuilder.InsertData(
                table: "IotDevices",
                columns: new[] { "Id", "CreationTime", "CreatorId", "DeletionTime", "Icon", "IsDeleted", "Name", "Remark", "Stats", "Type", "UserInfoId" },
                values: new object[] { new Guid("67d0ebe4-80f1-4047-a774-58edc045b374"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "https://tokeniot.oss-cn-shenzhen.aliyuncs.com/icon/Dht.png", false, "温度计", "", 1, 0, new Guid("304e5cb4-cb63-4c45-a834-8cd43ea55c7e") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IotDevices",
                keyColumn: "Id",
                keyValue: new Guid("67d0ebe4-80f1-4047-a774-58edc045b374"));

            migrationBuilder.DeleteData(
                table: "IotUserInfo",
                keyColumn: "Id",
                keyValue: new Guid("304e5cb4-cb63-4c45-a834-8cd43ea55c7e"));

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "DHTLogs");

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "IotUserInfo",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "IotDevices",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "IotUserInfo",
                columns: new[] { "Id", "AccountNumber", "Avatar", "ConcurrencyStamp", "CreationTime", "CreatorId", "DeletionTime", "Introduce", "IsDeleted", "Name", "Password", "PhoneNumber", "State", "WeChatOpenId" },
                values: new object[] { new Guid("f2128057-61c5-4b0a-9a26-b0af8f31cb26"), "admin", "https://xiaohuchat.oss-cn-beijing.aliyuncs.com/ima/admin.jpg", "4f55fa02ea3944e8afcc26c0454c535e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "超级管理员", false, "管理员", "dd666666", "13049809673", 0, null });

            migrationBuilder.InsertData(
                table: "IotDevices",
                columns: new[] { "Id", "ConcurrencyStamp", "CreationTime", "CreatorId", "DeletionTime", "Icon", "IsDeleted", "Name", "Remark", "Stats", "Type", "UserInfoId" },
                values: new object[] { new Guid("0ac57608-7cf8-40fe-90c0-56700ac2798e"), "349b6cfc58f2422494a84403034875da", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "https://tokeniot.oss-cn-shenzhen.aliyuncs.com/icon/Dht.png", false, "温度计", "", 1, 0, new Guid("f2128057-61c5-4b0a-9a26-b0af8f31cb26") });
        }
    }
}
