
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Transactions;

namespace UnitOfWork.Infrastructure
{
    /// <summary>
    /// 业务方向上的CUD实现
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        private Dictionary<IAggregateRoot, IUnitOfWorkRepository> addedEntities;

        private Dictionary<IAggregateRoot, IUnitOfWorkRepository> changedEntities;

        private Dictionary<IAggregateRoot, IUnitOfWorkRepository> deletedEntities;


        public UnitOfWork()
        {
            addedEntities = new Dictionary<IAggregateRoot, IUnitOfWorkRepository>();
            changedEntities = new Dictionary<IAggregateRoot, IUnitOfWorkRepository>();
            deletedEntities = new Dictionary<IAggregateRoot, IUnitOfWorkRepository>();
        }


        public void RegisterNew(IAggregateRoot entity, IUnitOfWorkRepository unitOfWorkRepository)
        {
            if (!addedEntities.ContainsKey(entity))
            {
                addedEntities.Add(entity, unitOfWorkRepository);
            }
        }

        public void RegisterAmended(IAggregateRoot entity, IUnitOfWorkRepository unitOfWorkRepository)
        {
            if (!changedEntities.ContainsKey(entity))
            {
                changedEntities.Add(entity, unitOfWorkRepository);
            }
        }

        public void RegisterRemoved(IAggregateRoot entity, IUnitOfWorkRepository unitOfWorkRepository)
        {
            if (!deletedEntities.ContainsKey(entity))
            {
                deletedEntities.Add(entity, unitOfWorkRepository);
            }
        }

        public void Commit()
        {
            using (TransactionScope scope=new TransactionScope())
            {
                foreach (IAggregateRoot entity in this.addedEntities.Keys)
                {
                    this.addedEntities[entity].PersistCreationOf(entity);
                }
                foreach (IAggregateRoot entity in this.changedEntities.Keys)
                {
                    this.changedEntities[entity].PersistUpdateOf(entity);
                }
                foreach (IAggregateRoot entity in this.deletedEntities.Keys)
                {
                    this.deletedEntities[entity].PersistDeletionOf(entity);
                }
                scope.Complete();
            }
        }
    }
}
