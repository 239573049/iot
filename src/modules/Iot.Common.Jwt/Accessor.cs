using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Iot.Common.Jwt.Options;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using Volo.Abp;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Entities;

namespace Iot.Common.Jwt;

public class Accessor : ITransientDependency
{
    private readonly IHttpContextAccessor _contextAccessor;
    private readonly TokenOptions _tokenOptions;

    private readonly string _xTenantId = Constants.TenantHeader;

    public Accessor(IHttpContextAccessor contextAccessor, IOptions<TokenOptions> tokenOptions)
    {
        _contextAccessor = contextAccessor;
        _tokenOptions = tokenOptions.Value;
    }

    public string Name => _contextAccessor.HttpContext?.User.Identity?.Name ?? string.Empty;

    public Guid ID => Guid.Parse(GetClaimValueByType(Constants.Id).FirstOrDefault() ?? Guid.Empty.ToString());

    public Guid GetDeviceId()
    {
        var data = _contextAccessor.HttpContext?.Request.Headers[Constants.DeviceId];
        if (data.HasValue)
        {
            return Guid.Parse(data);
        }

        throw new BusinessException(IotDomainErrorCodes.IsNullDeviceId);
    }

    /// <summary>
    /// 获取设备模板Id
    /// </summary>
    /// <returns></returns>
    /// <exception cref="BusinessException"></exception>
    public Guid GetDeviceTemplateId()
    {
        var data = _contextAccessor.HttpContext?.Request.Headers[Constants.DeviceTemplateId];
        if (data.HasValue)
        {
            return Guid.Parse(data);
        }

        throw new BusinessException(IotDomainErrorCodes.IsNullDeviceTemplateId);
    }
    
    public bool? IsAuthenticated()
    {
        return _contextAccessor.HttpContext?.User.Identity?.IsAuthenticated;
    }

    public string GetToken()
    {
        return _contextAccessor.HttpContext?.Request.Headers[Constants.JwtHeader].ToString()
            .Replace(Constants.JwtType, "") ?? string.Empty;
    }

    public IEnumerable<Claim>? GetClaimsIdentity()
    {
        return _contextAccessor.HttpContext?.User.Claims;
    }

    public List<string>? GetClaimValueByType(string claimType)
    {
        return GetClaimsIdentity()?.Where(item => item.Type == claimType).Select(item => item.Value).ToList();
    }

    public List<string> GetUserInfoFromToken(string claimType)
    {
        var securityTokenHandler = new JwtSecurityTokenHandler();
        var token = GetToken();
        return !string.IsNullOrEmpty(token)
            ? securityTokenHandler.ReadJwtToken(token).Claims.Where(item => item.Type == claimType)
                .Select(item => item.Value).ToList()
            : new List<string>();
    }

    public string GetUser(string token)
    {
        var securityTokenHandler = new JwtSecurityTokenHandler();
        return securityTokenHandler.ReadJwtToken(token).Claims.Where(item => item.Type == Constants.User)
            .Select(item => item.Value).FirstOrDefault() ?? "";
    }

    public string GetTenantId()
    {
        var httpContext = _contextAccessor.HttpContext;
        return httpContext != null && httpContext.Request.Headers.ContainsKey(_xTenantId)
            ? httpContext.Request.Headers[_xTenantId].FirstOrDefault()
            : null;
    }

    public List<Guid> GetRoleIds()
    {
        var data = GetClaimValueByType(Constants.Role).FirstOrDefault();

        if (data.IsNullOrEmpty())
        {
            throw new BusinessException(IotDomainErrorCodes.Unauthorized);
        }
        
        return JsonConvert.DeserializeObject<List<Guid>>(data);
    }
    
    /// <summary>
    /// 获取当前用户id
    /// </summary>
    /// <returns></returns>
    /// <exception cref="BusinessException">账号未授权</exception>
    public Guid GetUserId()
    {
        var user = ID;
        if (user == Guid.Empty)
        {
            throw new BusinessException("401", "账号未授权");
        }

        return user;
    }

    public T? GetUserInfo<T>()
    {
        var result = GetClaimValueByType(Constants.User).FirstOrDefault() ??
                     throw new BusinessException("401", "账号未授权");
        return JsonConvert.DeserializeObject<T>(result);
    }

    public Task<string> CreateTokenAsync(Claim[] claims)
    {
        var keyBytes = Encoding.UTF8.GetBytes(_tokenOptions.SecretKey!);
        var cred = new SigningCredentials(new SymmetricSecurityKey(keyBytes),
            SecurityAlgorithms.HmacSha256);

        var jwtSecurityToken = new JwtSecurityToken(
            _tokenOptions.Issuer, // 签发者
            _tokenOptions.Audience, // 接收者
            claims, // payload
            expires: DateTime.Now.AddMinutes(_tokenOptions.ExpireMinutes), // 过期时间
            signingCredentials: cred); // 令牌
        var token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
        return Task.FromResult(token);
    }
}