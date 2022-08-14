using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Iot.EntityFrameworkCore.Dbmigrator.Migrations
{
    public partial class role : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IotDevices",
                keyColumn: "Id",
                keyValue: new Guid("5692e070-7613-40c2-8c37-5bf28cf0d82d"));

            migrationBuilder.DeleteData(
                table: "IotUserInfo",
                keyColumn: "Id",
                keyValue: new Guid("7df41acd-c9ff-4f63-8c68-43c4b4ed1d1d"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "IotUserInfo",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatorId",
                table: "IotUserInfo",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "IotDevices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatorId",
                table: "IotDevices",
                type: "uniqueidentifier",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "CreationTime",
                table: "IotUserInfo");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "IotUserInfo");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "IotDevices");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "IotDevices");

            migrationBuilder.InsertData(
                table: "IotUserInfo",
                columns: new[] { "Id", "AccountNumber", "Avatar", "ConcurrencyStamp", "DeletionTime", "Introduce", "IsDeleted", "Name", "Password", "PhoneNumber", "State", "WeChatOpenId" },
                values: new object[] { new Guid("7df41acd-c9ff-4f63-8c68-43c4b4ed1d1d"), "admin", "https://xiaohuchat.oss-cn-beijing.aliyuncs.com/ima/admin.jpg", "8f6db9de7bb249d8bac28a81bf0eed1f", null, "超级管理员", false, "管理员", "dd666666", "13049809673", 0, null });

            migrationBuilder.InsertData(
                table: "IotDevices",
                columns: new[] { "Id", "ConcurrencyStamp", "DeletionTime", "Icon", "IsDeleted", "Name", "Remark", "Stats", "Type", "UserInfoId" },
                values: new object[] { new Guid("5692e070-7613-40c2-8c37-5bf28cf0d82d"), "b2806e929d734c6991ca3af548d8b0a8", null, "https://tokeniot.oss-cn-shenzhen.aliyuncs.com/icon/Dht.png", false, "温度计", "", 1, 0, new Guid("7df41acd-c9ff-4f63-8c68-43c4b4ed1d1d") });
        }
    }
}
