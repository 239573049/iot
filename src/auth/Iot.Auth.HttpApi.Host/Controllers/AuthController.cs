using Iot.Auth.Application.Contracts.Auth;
using Iot.Auth.Application.Contracts.Auth.Views;
using Microsoft.AspNetCore.Mvc;

namespace Iot.Auth.HttpApi.Host.Controllers;

/// <summary>
/// 授权中心
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;

    /// <inheritdoc />
    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }


    /// <summary>
    /// 授权
    /// </summary>
    /// <returns></returns>
    [HttpPost]
    public async Task<string> AuthAsync(AuthInput input) =>
        await _authService.AuthAsync(input);

    /// <summary>
    /// 刷新token
    /// </summary>
    /// <returns></returns>
    [HttpPut("refresh")]
    public  async Task<string> RefreshAsync() =>
        await _authService.PutRefreshAsync();
}