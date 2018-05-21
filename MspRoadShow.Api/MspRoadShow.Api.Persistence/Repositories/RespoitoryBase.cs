using Microsoft.EntityFrameworkCore;
using MspRoadShow.Api.Business.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MspRoadShow.Api.Persistence.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly DbContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public RepositoryBase(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public async Task Create(TEntity entity)
        {
            _dbSet.Add(entity);
            await _context.SaveChangesAsync().ConfigureAwait(false);
        }

        public async Task<TEntity> FindById(int id)
        {
            return await _dbSet.FindAsync(id).ConfigureAwait(false);
        }

        public async Task<TEntity> FindById(Guid id)
        {
            return await _dbSet.FindAsync(id).ConfigureAwait(false);
        }

        public async Task<IList<TEntity>> Get()
        {
            return await _dbSet.AsNoTracking().ToListAsync().ConfigureAwait(false);
        }

        public async Task<IList<TEntity>> Get(Func<TEntity, bool> predicate)
        {
            return  _dbSet.AsNoTracking()
                .Where(predicate)
                .ToList();
        }

        public async Task Remove(TEntity item)
        {
            _dbSet.Remove(item);
            await _context.SaveChangesAsync().ConfigureAwait(false);
        }

        public async Task Update(TEntity item)
        {
            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync().ConfigureAwait(false);
        }
    }
}
