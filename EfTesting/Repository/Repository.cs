using EfTesting.DbContext;
using EfTesting.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace EfTesting.Repository;

/// <inheritdoc />
public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, IDatabaseEntity
{
    protected readonly FecContext Context;

    /// <summary>
    /// Initialize an instance of this class.
    /// </summary>
    /// <param name="context">A database context.</param>
    public Repository(FecContext context)
    {
        Context = context;
    }

    /// <inheritdoc />
    public ValueTask<TEntity?> Find(int id)
    {
        return Context.Set<TEntity>().FindAsync(id);
    }

    public Task<TEntity?> Find(int id, params Expression<Func<TEntity, object>>[] includeProperties)
    {
        IQueryable<TEntity> query = Context.Set<TEntity>();
        foreach (var includeProperty in includeProperties)
        {
            query = query.Include(includeProperty);
        }
        return query.FirstOrDefaultAsync(p => p.UniqueId == id);
    }

    /// <inheritdoc />
    public IQueryable<TEntity> GetAll(params Expression<Func<TEntity, object>>[] includeProperties)
    {
        IQueryable<TEntity> query = Context.Set<TEntity>();
        foreach (var includeProperty in includeProperties)
        {
            query = query.Include(includeProperty);
        }
        return query;
    }

    public TEntity? GetFirstOrDefault()
    {
        return Context.Set<TEntity>().FirstOrDefault();
    }

    /// <inheritdoc />
    public IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includeProperties)
    {
        IQueryable<TEntity> query = Context.Set<TEntity>().Where(predicate);

        foreach (var includeProperty in includeProperties)
        {
            query = query.Include(includeProperty);
        }

        return query;
    }

    /// <inheritdoc />
    public void Add(TEntity entity)
    {
        Context.Set<TEntity>().Add(entity);
    }

    /// <inheritdoc />
    public void AddRange(IEnumerable<TEntity> entities)
    {
        Context.Set<TEntity>().AddRange(entities);
    }

    /// <inheritdoc />
    public void Remove(TEntity entity)
    {
        Context.Set<TEntity>().Remove(entity);
    }

    /// <inheritdoc />
    public void RemoveRange(IEnumerable<TEntity> entities)
    {
        Context.Set<TEntity>().RemoveRange(entities);
    }

    /// <inheritdoc />
    public async Task Save()
    {
        await Context.SaveChangesAsync();
    }

    /// <inheritdoc />
    public void Update(TEntity entity)
    {
        Context.Update(entity);
    }
}
