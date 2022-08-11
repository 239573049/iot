using System;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;

namespace Iot;


public class IotAggregateRoot<T> : AggregateRoot<T>, IHasDeletionTime, IHasCreationTime, IMayHaveCreator
{
    public bool IsDeleted { get; set; }

    public DateTime? DeletionTime { get; set; }

    public DateTime CreationTime { get; }

    public Guid? CreatorId { get; }

    public IotAggregateRoot()
    {
    }

    public IotAggregateRoot(T id) : base(id)
    {
    }

    public IotAggregateRoot(T id, bool isDeleted, DateTime? deletionTime, DateTime creationTime, Guid? creatorId) :
        base(id)
    {
        IsDeleted = isDeleted;
        DeletionTime = deletionTime;
        CreationTime = creationTime;
        CreatorId = creatorId;
    }
}