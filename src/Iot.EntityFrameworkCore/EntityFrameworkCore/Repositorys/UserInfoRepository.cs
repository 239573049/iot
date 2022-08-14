using System;
using Iot.Users;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Iot.EntityFrameworkCore.Repositorys;

public class UserInfoRepository:EfCoreRepository<IotDbContext,UserInfo,Guid>,IUserInfoRepository
{
    public UserInfoRepository(IDbContextProvider<IotDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
    
}