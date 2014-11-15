using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitOfWork.Infrastructure
{
    /// <summary>
    /// 持久化方向上的CUD
    /// </summary>
    public interface IUnitOfWorkRepository
    {
        void PersistCreationOf(IAggregateRoot entity);

        void PersistUpdateOf(IAggregateRoot entity);

        void PersistDeletionOf(IAggregateRoot entity);
    }
}
