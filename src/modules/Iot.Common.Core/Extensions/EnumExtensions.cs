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
        if (value == null) return null;

        var attributes= value.GetType().GetCustomAttributes<DescriptionAttribute>();
        if (attributes?.Any()==true)
        {
            return attributes.FirstOrDefault().Description;
        }

        return value.ToString();
    }
}