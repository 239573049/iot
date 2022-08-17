using Iot.Auth.Application.Contracts.Auth;
using Iot.Auth.Application.Contracts.Auth.Views;
using Iot.Common.Jwt;
using Iot.Localization;
using Iot.Users;
using Microsoft.Extensions.Localization;
using Volo.Abp;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Iot.Auth.Application.Auth;

public class AuthService : ApplicationService, IAuthService
{
    private readonly IRepository<UserInfo, Guid> _userInfoRepository;
    private readonly Accessor _accessor;

    public AuthService(IRepository<UserInfo, Guid> userInfoRepository, Accessor accessor)
    {
        _userInfoRepository = userInfoRepository;
        _accessor = accessor;
    }


    /// <inheritdoc />
    public async Task<string> AuthAsync(AuthInput input)
    {
        var userInfo = await
            _userInfoRepository.FirstOrDefaultAsync(x =>
                x.Password == x.Password &&
                (x.AccountNumber == input.AccountNumber || x.PhoneNumber == input.AccountNumber));

        if (userInfo == null)
        {
            throw new BusinessException(IotDomainErrorCodes.NotUserName);
        }

        var token = await _accessor.CreateTokenAsync(userInfo);

        return token;
    }

    /// <inheritdoc />
    public async Task<string> RefreshAsync()
    {
        var userInfo = _accessor.GetUserInfo<UserInfo>();
        
        var token = await _accessor.CreateTokenAsync(userInfo);

        return token;
        
    }

    /// <inheritdoc />
    public Task<string> WeChatAuthAsync(WeChatAuthInput input)
    {
        throw new Exception();
    }
}