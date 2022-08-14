using System;
using Volo.Abp.Auditing;
using Volo.Abp.Data;
using Volo.Abp.Domain.Entities;

namespace Iot;


public class IotAggregateRoot<T> : BasicAggregateRoot<T>, IHasDeletionTime, IHasCreationTime, IMayHaveCreator
{
    public bool IsDeleted { get;  set; }

    public DateTime? DeletionTime { get;  set; }

    public DateTime CreationTime { get;  set; }

    public Guid? CreatorId { get;set; }

    public ExtraPropertyDictionary ExtraProperties { get; protected set; }

    public IotAggregateRoot()
    {
    }

}