namespace Iot.Auth.Application.Contracts.Auth.Views;

public class AuthInput
{
    /// <summary>
    /// 账号
    /// </summary>
    public string? AccountNumber { get; set; }
    
    /// <summary>
    /// 密码
    /// </summary>
    public string? Password { get;  set; }
}