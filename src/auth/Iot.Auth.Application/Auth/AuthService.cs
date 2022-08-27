using System.Security.Claims;
using Iot.Auth.Application.Contracts.Auth;
using Iot.Auth.Application.Contracts.Auth.Views;
using Iot.Auth.Domain.Roles;
using Iot.Auth.Domain.Roles.Views;
using Iot.Common.Jwt;
using Iot.Users;
using Newtonsoft.Json;
using Volo.Abp;
using Volo.Abp.Application.Services;

namespace Iot.Auth.Application.Auth;

public class AuthService : ApplicationService, IAuthService
{
    private readonly IRoleRepository _userInfoRepository;
    private readonly Accessor _accessor;

    public AuthService(Accessor accessor, IRoleRepository userInfoRepository)
    {
        _accessor = accessor;
        _userInfoRepository = userInfoRepository;
    }


    /// <inheritdoc />
    public async Task<string> AuthAsync(AuthInput input)
    {
        var userInfo = await
            _userInfoRepository.GetAuthUserInfoAsync(input.AccountNumber,input.Password);

        if (userInfo == null)
        {
            throw new BusinessException(IotDomainErrorCodes.NotUserName);
        }

        
        var claims = new[]
        {
            new Claim(Constants.User, JsonConvert.SerializeObject(userInfo)),
            new Claim(Constants.Id, userInfo.Id.ToString()),
            new Claim(Constants.Role,JsonConvert.SerializeObject(userInfo.Roles))
        };

        
        var token = await _accessor.CreateTokenAsync(claims);

        return token;
    }

    /// <inheritdoc />
    public async Task<string> PutRefreshAsync()
    {
        var userInfo = _accessor.GetUserInfo<AuthUserInfoViews>();

        
        var claims = new[]
        {
            new Claim(Constants.User, JsonConvert.SerializeObject(userInfo)),
            new Claim(Constants.Id, userInfo.Id.ToString()),
            new Claim(Constants.Role,JsonConvert.SerializeObject(userInfo.Roles))
        };
        
        var token = await _accessor.CreateTokenAsync(claims);

        return token;
    }

    /// <inheritdoc />
    public Task<string> WeChatAuthAsync(WeChatAuthInput input)
    {
        throw new Exception();
    }
}