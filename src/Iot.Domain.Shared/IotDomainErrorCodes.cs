namespace Iot;

public static class IotDomainErrorCodes
{
    #region Auth

    private const string Auth = "Auth:";

    /// <summary>
    /// 账号不存在
    /// </summary>
    public const string NotUserName = Auth + "NotUserName";

    /// <summary>
    /// 未授权
    /// </summary>
    public const string Unauthorized = Auth + "Unauthorized";
    
    /// <summary>
    /// 设备id为空
    /// </summary>
    public const string IsNullDeviceId = Auth + "IsNullDeviceId";
    
    /// <summary>
    /// 设备模板id为空
    /// </summary>
    public const string IsNullDeviceTemplateId = Auth + "IsNullDeviceTemplateId";
    
    #endregion

    #region Admin

    private const string Admin = "Admin:";

    public const string NotUserInfoId = Admin + "NotUserInfoId";

    public const string NotNullDeviceId = Admin + "NotNullDeviceId";

    /// <summary>
    /// 当前文件夹存在相同名称
    /// </summary>
    public const string ExistTreeDeviceTitle = Admin + "ExistTreeDeviceTitle";

    #endregion
}