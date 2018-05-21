using MspRoadShow.Api.Business.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MspRoadShow.Api.Business.Services
{
    public class ServiceBase<T> where T: class
    {
        readonly IRepositoryBase<T> _repository;

        public ServiceBase(IRepositoryBase<T> repository)
        {
            _repository = repository;
        }

        public async Task CreateEntityAsync(T entity)
        {
            await _repository.Create(entity).ConfigureAwait(false);
        }

        public async Task UpdateEntityAsync(T entity)
        {
            await _repository.Update(entity).ConfigureAwait(false);
        }

        public async Task<IList<T>> SelectEntiteAsync()
        {
            return await _repository.Get().ConfigureAwait(false);
        }

        public async Task DeleteEntityAsync(T entity)
        {
            await _repository.Remove(entity).ConfigureAwait(false);
        }
    }
}
