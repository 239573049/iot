using Iot.Auth.Domain.Roles.Views;

namespace Iot.Auth.Domain.Roles;

public interface IRoleRepository
{
    Task<AuthUserInfoViews> GetAuthUserInfoAsync(string accountNumber, string password);
}