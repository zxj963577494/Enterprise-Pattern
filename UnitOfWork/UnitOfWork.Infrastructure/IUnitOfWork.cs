using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitOfWork.Infrastructure
{
    /// <summary>
    /// 业务方向上的CUD接口
    /// </summary>
    public interface IUnitOfWork
    {
        void RegisterNew(IAggregateRoot entity, IUnitOfWorkRepository unitOfWorkRepository);

        void RegisterAmended(IAggregateRoot entity, IUnitOfWorkRepository unitOfWorkRepository);

        void RegisterRemoved(IAggregateRoot entity, IUnitOfWorkRepository unitOfWorkRepository);

        void Commit();
    }
}
