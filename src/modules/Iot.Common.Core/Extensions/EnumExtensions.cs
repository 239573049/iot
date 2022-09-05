using System.ComponentModel;
using System.Reflection;

namespace Iot.Common.Core.Extensions;

public static class EnumExtensions
{
    /// <summary>
    /// 获取枚举值的描述信息
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static string GetDescription(this Enum value)
    {

        return value.GetType().GetMember(value.ToString()).FirstOrDefault()?.GetCustomAttribute<DescriptionAttribute>()?.Description ?? null;
    }
}