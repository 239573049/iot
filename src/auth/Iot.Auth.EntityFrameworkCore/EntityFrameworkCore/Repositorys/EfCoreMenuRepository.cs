using Iot.Auth.Domain.Roles;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Iot.Auth.EntityFrameworkCore.EntityFrameworkCore.Repositorys;

public class EfCoreMenuRepository : EfCoreRepository<IotAuthDbContext,Menu,Guid>,IMenuRepository
{
    public EfCoreMenuRepository(IDbContextProvider<IotAuthDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

    /// <inheritdoc />
    public async Task<List<Menu>> GetRoleMenusAsync(List<Guid> roleId)
    {
        var dbContext = await GetDbContextAsync();

        var query = dbContext.MenuRoleFunction
            .AsSplitQuery()
            .Where(x => roleId.Contains(x.RoleId))
            .Include(x => x.Menu)
            .Select(x => x.Menu);

        return await query.ToListAsync();
    }
}