using System.Text;
using Iot.Common.Jwt.Options;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Volo.Abp.Modularity;

namespace Iot.Common.Jwt;

public class IotCommonJwtModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        ConfigureAuthentication(context, context.Services.GetConfiguration());
    }

    private void ConfigureAuthentication(ServiceConfigurationContext context, IConfiguration configuration)
    {
        var configurationSection = configuration.GetSection(nameof(TokenOptions));

        context.Services.Configure<TokenOptions>(configurationSection);

        var tokenOptions = configurationSection.Get<TokenOptions>();
        if (string.IsNullOrEmpty(tokenOptions.Issuer))
            throw new Exception("未设置JWT权限配置");

        context.Services.Configure<TokenOptions>(configurationSection);
        context.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true, //是否在令牌期间验证签发者
                    ValidateAudience = true, //是否验证接收者
                    ValidateLifetime = true, //是否验证失效时间
                    ValidateIssuerSigningKey = true, //是否验证签名
                    ValidAudience = tokenOptions.Audience, //接收者
                    ValidIssuer = tokenOptions.Issuer, //签发者，签发的Token的人
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenOptions.SecretKey!))
                };
                // options.Events = new JwtBearerEvents
                // {
                //     OnMessageReceived = (context) =>
                //     {
                //         // 添加signalr的token 因为signalr的token在请求头上所以需要设置
                //         var accessToken = context.Request.Query["access_token"];
                //         var path = context.HttpContext.Request.Path;
                //         if (!string.IsNullOrEmpty(accessToken) && path.StartsWithSegments(SignalRConstants.FileStream))
                //         {
                //             context.Token = accessToken;
                //         }
                //
                //         return Task.CompletedTask;
                //     }
                // };
            });
    }
}