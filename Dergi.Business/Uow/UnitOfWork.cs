using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Entity.Infrastructure;
using System.Linq;
using Dergi.Model.Repo;

namespace Dergi.Business.Uow
{
    public interface IUnitOfWork : IDisposable
    {
        IRepositoryGeneric<TSet> GetRepository<TSet>() where TSet : BaseEntity;

        IRepositoryType GetRepository(Type type);

        DbTransaction BeginTransaction();

        int Save();

        DergiDbContext GetCurrentDataContext();

    }
    public class UnitOfWork : IUnitOfWork
    {
        private static UnitOfWork _instance;
        private DbTransaction _transaction;

        private readonly Dictionary<Type, object> _repositoriesGeneric;

        private readonly Dictionary<Type, object> _repositoriesType;

        private readonly DergiDbContext _ctx;
        public UnitOfWork()
        {
            _ctx = new DergiDbContext();

            _repositoriesGeneric = new Dictionary<Type, object>();

            _repositoriesType = new Dictionary<Type, object>();
        }

        public IRepositoryGeneric<TSet> GetRepository<TSet>() where TSet : BaseEntity
        {
            if (_repositoriesGeneric.Keys.Contains(typeof(TSet)))
                return _repositoriesGeneric[typeof(TSet)] as IRepositoryGeneric<TSet>;

            var repository = new RepositoryGeneric<TSet>(_ctx);

            _repositoriesGeneric.Add(typeof(TSet), repository);

            return repository;
        }
        public IRepositoryType GetRepository(Type entityType)
        {
            if (_repositoriesType.Keys.Contains(entityType))
                return _repositoriesType[entityType] as IRepositoryType;

            var repository = new RepositoryType(_ctx, entityType);

            _repositoriesType.Add(entityType, repository);

            return repository;
        }
        public DbTransaction BeginTransaction()
        {
            if (_transaction == null)
            {
                if (_ctx.Database.Connection.State != ConnectionState.Open)
                {
                    //_ctx.Database.Connection.Open();
                    ((IObjectContextAdapter)_ctx).ObjectContext.Connection.Open();
                }

                this._transaction = _ctx.Database.Connection.BeginTransaction();
            }

            return _transaction;
        }
        public int Save()
        {
            return _ctx.SaveChanges();
        }
        public DergiDbContext GetCurrentDataContext()
        {
            return _ctx;
        }
        #region IDisposable Members

        public void Dispose()
        {
            if (null != _transaction)
            {
                _transaction.Dispose();
            }

            if (null != _ctx)
            {
                _ctx.Dispose();
            }

        }
        public static UnitOfWork Instance
        {
            get { return _instance ?? (_instance = new UnitOfWork()); }
        }
        #endregion
    }

}