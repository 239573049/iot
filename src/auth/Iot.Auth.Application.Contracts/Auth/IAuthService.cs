using Iot.Auth.Application.Contracts.Auth.Views;

namespace Iot.Auth.Application.Contracts.Auth;

public interface IAuthService
{
    /// <summary>
    /// 授权
    /// </summary>
    /// <returns></returns>
    Task<string> AuthAsync(AuthInput input);

    /// <summary>
    /// 刷新token
    /// </summary>
    /// <returns></returns>
    Task<string> PutRefreshAsync();

    /// <summary>
    /// 微信一键登录
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    Task<string> WeChatAuthAsync(WeChatAuthInput input);
}