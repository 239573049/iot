using System;
using System.Collections.Generic;
using Iot.Devices;
using Iot.Users;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Iot.EntityFrameworkCore;

public static class IotEntityFrameworkCoreExtension
{
    public static void ConfigureIot(this ModelBuilder builder)
    {
        builder.Entity<UserInfo>(x =>
        {
            x.ToTable("IotUserInfo");
            x.HasComment("用户信息");

            x.HasIndex(x => x.Id);
            x.HasKey(x => x.Id);
            x.HasIndex(x => new { x.AccountNumber, x.Password });
            x.HasIndex(x => x.WeChatOpenId);

            x.Property(x => x.AccountNumber).HasComment("账号");
            x.Property(x => x.Password).HasComment("密码");
            x.Property(x => x.Name).HasComment("昵称");
            x.Property(x => x.Avatar).HasComment("头像");
            x.Property(x => x.State).HasComment("账号状态");
            x.Property(x => x.PhoneNumber).HasComment("手机号");
        });

        builder.Entity<DHTxxLogs>(x =>
        {
            x.ToTable("DHTLogs");
            x.HasComment("DHT运行记录");

            x.HasIndex(x => x.Id);
            x.HasKey(x => x.Id);

            x.HasIndex(x => x.DeviceId);

            // 将字典类型转换字符串存储在数据库
            x.Property(x => x.Logs)
                .HasConversion(x => JsonConvert.SerializeObject(x),
                    x => JsonConvert.DeserializeObject<Dictionary<string, string>>(x) ??
                         new Dictionary<string, string>());
        });

        builder.Entity<IotDevices>(x =>
        {
            x.ToTable("IotDevices");
            x.HasComment("设备信息");

            x.HasIndex(x => x.Id);
            x.HasKey(x => x.Id);

            x.HasIndex(x => x.UserInfoId);
        });

        builder.ConfigureIotData();
    }

    private static void ConfigureIotData(this ModelBuilder builder)
    {
        var userId = Guid.NewGuid();
        var iotUser = new UserInfo(userId, "admin", "13049809673", null, "dd666666",
            "https://xiaohuchat.oss-cn-beijing.aliyuncs.com/ima/admin.jpg", "超级管理员", UserInfoState.InUse, "管理员");
        builder.Entity<UserInfo>().HasData(iotUser);

        var iotId = Guid.NewGuid();
        var iot = new IotDevices(iotId, "温度计", "https://tokeniot.oss-cn-shenzhen.aliyuncs.com/icon/Dht.png",
            DeviceType.DHT, "", DeviceStats.OffLine, userId);

        builder.Entity<IotDevices>().HasData(iot);
    }
}