using Iot.Auth.Application.Contracts.Auth.Views;

namespace Iot.Auth.Application.Contracts.Auth;

public interface IAuthService
{
    /// <summary>
    /// 授权
    /// </summary>
    /// <returns></returns>
    Task<string> Auth(AuthInput input);
}