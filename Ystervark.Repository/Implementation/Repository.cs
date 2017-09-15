using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Query;
using Ystervark.Models.Interface;
using Ystervark.Repository.Extensions;
using Ystervark.Repository.Interface;

namespace Ystervark.Repository.Implementation
{
    /// <inheritdoc />
    /// <summary>
    /// Represents a default generic repository implements the <see cref="T:Ystervark.Repository.Interface.IRepository`1" /> interface.
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity.</typeparam>
    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity : class
    {
        #region Repository - Privates

        /// <summary>
        /// The database context
        /// </summary>
        private readonly DbContext _dbContext;

        /// <summary>
        /// The database set
        /// </summary>
        private readonly DbSet<TEntity> _dbSet;

        /// <summary>
        /// The tenant identifier
        /// </summary>
        private readonly int? _tenantId;

        /// <summary>
        /// The tenant identifier property
        /// </summary>
        private readonly PropertyInfo _tenantIdProperty = typeof(ITenant).GetProperty(TenantIdStr);

        #endregion

        #region Repository - CONST

        /// <summary>
        /// The tenant identifier string
        /// </summary>
        private const string TenantIdStr = "TenantId";

        #endregion

        #region Repository - CTOR

        /// <summary>
        /// Initializes a new instance of the <see cref="Repository{TEntity}"/> class.
        /// </summary>
        /// <param name="dbContext">The database context.</param>
        public Repository(DbContext dbContext)
        {
            this._dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            this._dbSet = _dbContext.Set<TEntity>();
        }

        #endregion

        #region Repository - Private Worker Methods

        /// <summary>
        /// Filters the by tenant.
        /// </summary>
        /// <typeparam name="TObject">The type of the object.</typeparam>
        /// <param name="tenantId">The tenant identifier.</param>
        /// <returns></returns>
        private Expression<Func<TObject, bool>> FilterByTenant<TObject>(int tenantId)
        {
            var item = Expression.Parameter(typeof(TObject), "tenantFilter");
            var propertyValue = Expression.Property(item, _tenantIdProperty);
            var body = Expression.Equal(propertyValue, Expression.Constant(tenantId));
            return Expression.Lambda<Func<TObject, bool>>(body, item);
        }

        /// <summary>
        /// Sets the tenant identifier.
        /// </summary>
        /// <param name="obj">The object.</param>
        private void SetTenantId(TEntity obj)
        {
            if (obj is ITenant tenant)
            {
                tenant.TenantId = this._tenantId ?? -1;
            }
        }

        /// <summary>
        /// Evaluates the TObject to determine whether it is of <see cref="ITenant" />, if so it will alter the expression tree and add a condition
        /// </summary>
        /// <param name="query">The query.</param>
        /// <returns>
        /// queryable object collection
        /// </returns>
        private IQueryable<TEntity> TenantFilterQueryable(IQueryable<TEntity> query)
        {
            if (!typeof(TEntity).GetInterfaces().Contains(typeof(ITenant)) || !this._tenantId.HasValue || this._tenantId.Equals(-1))
            {
                return query;
            }

            var filter = this.FilterByTenant<TEntity>(this._tenantId.Value);
            query = query.Where(filter);
            return query;
        }

        #endregion

        /// <inheritdoc />
        /// <summary>
        /// Changes the table name. This require the tables in the same database.
        /// </summary>
        /// <param name="table"></param>
        /// <remarks>
        /// This only been used for supporting multiple tables in the same model. This require the tables in the same database.
        /// </remarks>
        public void ChangeTable(string table)
        {
            if (_dbContext.Model.FindEntityType(typeof(TEntity)).Relational() is RelationalEntityTypeAnnotations relational)
            {
                relational.TableName = table;
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the <see cref="T:Ystervark.Repository.Extensions.IPagedList`1" /> based on a predicate, order by delegate and page information. This method default no-tracking query.
        /// </summary>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <param name="orderBy">A function to order elements.</param>
        /// <param name="include">A function to include navigation properties</param>
        /// <param name="pageIndex">The index of page.</param>
        /// <param name="pageSize">The size of the page.</param>
        /// <param name="disableTracking"><c>True</c> to disable changing tracking; otherwise, <c>false</c>. Default to <c>true</c>.</param>
        /// <returns>An <see cref="T:Ystervark.Repository.Extensions.IPagedList`1" /> that contains elements that satisfy the condition specified by <paramref name="predicate" />.</returns>
        /// <remarks>This method default no-tracking query.</remarks>
        public IPagedList<TEntity> GetPagedList(Expression<Func<TEntity, bool>> predicate = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null, int pageIndex = 0, int pageSize = 20,
            bool disableTracking = true)
        {
            IQueryable<TEntity> query = _dbSet;
            if (disableTracking)
            {
                query = query.AsNoTracking();
            }

            if (include != null)
            {
                query = include(query);
            }

            if (predicate != null)
            {
                query = query.Where(predicate);
            }

            return orderBy != null ? orderBy(query).ToPagedList(pageIndex, pageSize) : query.ToPagedList(pageIndex, pageSize);
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the <see cref="T:Ystervark.Repository.Extensions.IPagedList`1" /> based on a predicate, order by delegate and page information. This method default no-tracking query.
        /// </summary>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <param name="orderBy">A function to order elements.</param>
        /// <param name="include">A function to include navigation properties</param>
        /// <param name="pageIndex">The index of page.</param>
        /// <param name="pageSize">The size of the page.</param>
        /// <param name="disableTracking"><c>True</c> to disable changing tracking; otherwise, <c>false</c>. Default to <c>true</c>.</param>
        /// <param name="cancellationToken">
        ///     A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>An <see cref="T:Ystervark.Repository.Extensions.IPagedList`1" /> that contains elements that satisfy the condition specified by <paramref name="predicate" />.</returns>
        /// <remarks>This method default no-tracking query.</remarks>
        public Task<IPagedList<TEntity>> GetPagedListAsync(Expression<Func<TEntity, bool>> predicate = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null, int pageIndex = 0, int pageSize = 20,
            bool disableTracking = true, CancellationToken cancellationToken = default(CancellationToken))
        {
            IQueryable<TEntity> query = _dbSet;
            if (disableTracking)
            {
                query = query.AsNoTracking();
            }

            if (include != null)
            {
                query = include(query);
            }

            if (predicate != null)
            {
                query = query.Where(predicate);
            }

            return orderBy?.Invoke(query).ToPagedListAsync(pageIndex, pageSize, 0, cancellationToken) ??
                   query.ToPagedListAsync(pageIndex, pageSize, 0, cancellationToken);
        }

        /// <inheritdoc />
        /// <summary>
        /// Uses raw SQL queries to fetch the specified <typeparamref name="TEntity" /> data.
        /// </summary>
        /// <param name="sql">The raw SQL.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>An <see cref="T:System.Linq.IQueryable`1" /> that contains elements that satisfy the condition specified by raw SQL.</returns>
        public IQueryable<TEntity> FromSql(string sql, params object[] parameters) => _dbSet.FromSql(sql, parameters);

        /// <inheritdoc />
        /// <summary>
        /// Finds an entity with the given primary key values. If found, is attached to the context and returned. If no entity is found, then null is returned.
        /// </summary>
        /// <param name="keyValues">The values of the primary key for the entity to be found.</param>
        /// <returns>The found entity or null.</returns>
        public TEntity Find(params object[] keyValues) => _dbSet.Find(keyValues);

        /// <inheritdoc />
        /// <summary>
        /// Finds an entity with the given primary key values. If found, is attached to the context and returned. If no entity is found, then null is returned.
        /// </summary>
        /// <param name="keyValues">The values of the primary key for the entity to be found.</param>
        /// <returns>A <see cref="T:System.Threading.Tasks.Task`1" /> that represents the asynchronous insert operation.</returns>
        public Task<TEntity> FindAsync(params object[] keyValues) => _dbSet.FindAsync(keyValues);

        /// <inheritdoc />
        /// <summary>
        /// Finds an entity with the given primary key values. If found, is attached to the context and returned. If no entity is found, then null is returned.
        /// </summary>
        /// <param name="keyValues">The values of the primary key for the entity to be found.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>A <see cref="T:System.Threading.Tasks.Task`1" /> that represents the asynchronous find operation. The task result contains the found entity or null.</returns>
        public Task<TEntity> FindAsync(object[] keyValues, CancellationToken cancellationToken) => _dbSet.FindAsync(keyValues, cancellationToken);

        /// <summary>
        /// Finds the asynchronous.
        /// </summary>
        /// <param name="match">The match.</param>
        /// <param name="include">The include.</param>
        /// <returns></returns>
        public Task<TEntity> FindAsync(Expression<Func<TEntity, bool>> match,
            Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null)
        {
            IQueryable<TEntity> query = _dbSet;
            if (include != null)
            {
                query = include(query);
            }

            return query.SingleOrDefaultAsync(match);
        }

        /// <summary>
        /// Finds the first or default.
        /// </summary>
        /// <param name="match">The match.</param>
        /// <param name="include"></param>
        /// <returns></returns>
        public Task<TEntity> FindFirstOrDefault(Expression<Func<TEntity, bool>> match,
            Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null)
        {
            IQueryable<TEntity> query = _dbSet;
            if (include != null)
            {
                query = include(query);
            }

            return query.FirstOrDefaultAsync(match);
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the count based on a predicate.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public int Count(Expression<Func<TEntity, bool>> predicate = null)
        {
            return _dbSet.Count(predicate);
        }

        /// <inheritdoc />
        /// <summary>
        /// Inserts a new entity synchronously.
        /// </summary>
        /// <param name="entity">The entity to insert.</param>
        public void Insert(TEntity entity)
        {
            var entry = _dbSet.Add(entity);
        }

        /// <inheritdoc />
        /// <summary>
        /// Inserts a range of entities synchronously.
        /// </summary>
        /// <param name="entities">The entities to insert.</param>
        public void Insert(params TEntity[] entities) => _dbSet.AddRange(entities);

        /// <inheritdoc />
        /// <summary>
        /// Inserts a range of entities synchronously.
        /// </summary>
        /// <param name="entities">The entities to insert.</param>
        public void Insert(IEnumerable<TEntity> entities) => _dbSet.AddRange(entities);

        /// <inheritdoc />
        /// <summary>
        /// Inserts a new entity asynchronously.
        /// </summary>
        /// <param name="entity">The entity to insert.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>A <see cref="T:System.Threading.Tasks.Task" /> that represents the asynchronous insert operation.</returns>
        public Task InsertAsync(TEntity entity, CancellationToken cancellationToken = default(CancellationToken))
        {
            return _dbSet.AddAsync(entity, cancellationToken);

            // Shadow properties?
            //var property = _dbContext.Entry(entity).Property("Created");
            //if (property != null) {
            //property.CurrentValue = DateTime.Now;
            //}
        }

        /// <inheritdoc />
        /// <summary>
        /// Inserts a range of entities asynchronously.
        /// </summary>
        /// <param name="entities">The entities to insert.</param>
        /// <returns>A <see cref="T:System.Threading.Tasks.Task" /> that represents the asynchronous insert operation.</returns>
        public Task InsertAsync(params TEntity[] entities) => _dbSet.AddRangeAsync(entities);

        /// <inheritdoc />
        /// <summary>
        /// Inserts a range of entities asynchronously.
        /// </summary>
        /// <param name="entities">The entities to insert.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>A <see cref="T:System.Threading.Tasks.Task" /> that represents the asynchronous insert operation.</returns>
        public Task InsertAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default(CancellationToken)) =>
            _dbSet.AddRangeAsync(entities, cancellationToken);

        /// <summary>
        /// Updates the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public void Update(TEntity entity)
        {
            _dbSet.Update(entity);

            // Shadow properties?
            //var property = _dbContext.Entry(entity).Property("LastUpdated");
            //if(property != null) {
            //property.CurrentValue = DateTime.Now;
            //}
        }

        /// <inheritdoc />
        /// <summary>
        /// Updates the specified entities.
        /// </summary>
        /// <param name="entities">The entities.</param>
        public void Update(params TEntity[] entities) => _dbSet.UpdateRange(entities);

        /// <summary>
        /// Updates the specified entities.
        /// </summary>
        /// <param name="entities">The entities.</param>
        public void Update(IEnumerable<TEntity> entities) => _dbSet.UpdateRange(entities);

        /// <summary>
        /// Deletes the specified entity.
        /// </summary>
        /// <param name="entity">The entity to delete.</param>
        public void Delete(TEntity entity) => _dbSet.Remove(entity);

        /// <summary>
        /// Deletes the entity by the specified primary key.
        /// </summary>
        /// <param name="id">The primary key value.</param>
        public void Delete(object id)
        {
            // using a stub entity to mark for deletion
            var typeInfo = typeof(TEntity).GetTypeInfo();
            var key = _dbContext.Model.FindEntityType(typeInfo.Name).FindPrimaryKey().Properties.FirstOrDefault();
            var property = typeInfo.GetProperty(key?.Name);
            if (property != null)
            {
                var entity = Activator.CreateInstance<TEntity>();
                property.SetValue(entity, id);
                _dbContext.Entry(entity).State = EntityState.Deleted;
            }
            else
            {
                var entity = _dbSet.Find(id);
                if (entity != null)
                {
                    Delete(entity);
                }
            }
        }

        /// <summary>
        /// Deletes the specified entities.
        /// </summary>
        /// <param name="entities">The entities.</param>
        public void Delete(params TEntity[] entities) => _dbSet.RemoveRange(entities);

        /// <summary>
        /// Deletes the specified entities.
        /// </summary>
        /// <param name="entities">The entities.</param>
        public void Delete(IEnumerable<TEntity> entities) => _dbSet.RemoveRange(entities);

        #region IHasTransactions Implementation

        /// <summary>
        /// Initiates a transaction scope.
        /// </summary>
        public void BeginTransaction()
        {
            this._dbContext.Database?.BeginTransaction();
        }

        /// <summary>
        /// Executes the transaction.
        /// </summary>
        public void CommitTransaction()
        {
            this._dbContext.Database?.CurrentTransaction?.Commit();
        }

        /// <summary>
        /// Rollbacks the transaction.
        /// </summary>
        public void RollbackTransaction()
        {
            this._dbContext.Database?.CurrentTransaction?.Rollback();
        }

        #endregion

        #region IDisposable Implementation

        /// <summary>
        /// Finalizes an instance of the <see cref="Repository{TObject}"/> class.
        /// </summary>
        ~Repository()
        {
            Dispose(false);
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Dispose managed resources
                this._dbContext?.Dispose();
            }

            // Free native resources
        }

        #endregion
    }
}