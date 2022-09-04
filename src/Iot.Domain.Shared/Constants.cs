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

    public const string DefaultFullDateFormat = "yyyy-MM-dd HH:mm:ss";

    public const string DefaultTodayDateStr = "yyyyMMdd";

    public const string DefaultFullDateStr = "yyyyMMddHHmmss";

    public const string DeviceId = "DeviceId";

    public static Guid AdminId = Guid.Parse("4754A271-42D5-4E0D-8298-41B19DD00AB3");
}