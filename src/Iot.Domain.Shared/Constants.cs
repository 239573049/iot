using System;

namespace Iot;

public class Constants
{
    public const string Id = "id";

    public const string User = "user";

    public const string Role = "Role";

    public const string TenantHeader = "X-TenantId";

    public const string JwtHeader = "Authorization";

    public const string JwtType = "Bearer ";

    public const string JsonType = "application/json";

    public const string CorsPolicy = nameof(CorsPolicy);

    public const string DefaultTodayDateFormat = "yyyy-MM-dd";

    /// <summary>
    /// 时间格式 yyyy-MM-dd HH:mm:ss
    /// </summary>
    public const string DefaultFullDateFormat = "yyyy-MM-dd HH:mm:ss";

    /// <summary>
    /// 时间格式 yyyyMMdd
    /// </summary>
    public const string DefaultTodayDateStr = "yyyyMMdd";

    /// <summary>
    /// 时间格式 yyyyMMddHHmmss
    /// </summary>
    public const string DefaultFullDateStr = "yyyyMMddHHmmss";

    /// <summary>
    /// 设备Id
    /// </summary>
    public const string DeviceId = "DeviceId";

    /// <summary>
    /// 设备模板
    /// </summary>
    public const string DeviceTemplateId = "DeviceTemplateId";

    /// <summary>
    /// 管理员Id
    /// </summary>
    public static Guid AdminId = Guid.Parse("4754A271-42D5-4E0D-8298-41B19DD00AB3");
}