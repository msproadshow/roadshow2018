using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MspRoadShow.Api.Business.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        Task Create(TEntity entity);
        Task<TEntity> FindById(int id);
        Task<TEntity> FindById(Guid id);
        Task<IList<TEntity>> Get();
        Task<IList<TEntity>> Get(Func<TEntity, bool> predicate);
        Task Remove(TEntity item);
        Task Update(TEntity item);
    }
}