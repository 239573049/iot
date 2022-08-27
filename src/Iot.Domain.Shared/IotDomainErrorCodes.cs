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
    
    #endregion

    #region Admin

    private const string Admin = "Admin:";

    public const string NotUserInfoId = Admin + "NotUserInfoId";

    public const string NotNullDeviceId = Admin + "NotNullDeviceId";

    #endregion
}