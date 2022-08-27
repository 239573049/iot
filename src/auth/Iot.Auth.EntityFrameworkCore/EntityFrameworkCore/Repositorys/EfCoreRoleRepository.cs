using Iot.Auth.Domain;
using Iot.Auth.Domain.Roles;
using Iot.Auth.Domain.Roles.Views;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Iot.Auth.EntityFrameworkCore.EntityFrameworkCore.Repositorys;

public class EfCoreRoleRepository : EfCoreRepository<IotAuthDbContext, Role, Guid>, IRoleRepository
{
    public EfCoreRoleRepository(IDbContextProvider<IotAuthDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

    /// <inheritdoc />
    public async Task<AuthUserInfoViews> GetAuthUserInfoAsync(string accountNumber, string password)
    {
        var dbContext = await GetDbContextAsync();

        var userInfo = await dbContext.AuthUserInfo
            .Where(x => x.AccountNumber == accountNumber || x.PhoneNumber == accountNumber)
            .Where(x => x.Password == password)
            .Select(x => new AuthUserInfoViews(x.Id, x.AccountNumber, x.PhoneNumber, x.WeChatOpenId, x.Password,
                x.Avatar, x.Introduce, x.State, x.Name))
            .FirstOrDefaultAsync();

        if (userInfo == null)
        {
            throw new BusinessException(IotDomainErrorCodes.NotUserName);
        }

        var roles = await dbContext.UserRoleFunction
            .AsSplitQuery()
            .Where(x => x.UserInfoId == userInfo.Id).Include(x => x.Role)
            .Select(x => x.Role.Id)
            .Distinct()
            .ToListAsync();

        userInfo.Roles = roles;

        return userInfo;
    }
}