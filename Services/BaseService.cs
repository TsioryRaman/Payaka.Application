using Payaka.Application.Services.Base;
using Payaka.Domain.Base;
using Payaka.Infrastructure.Repository.Base;
using System.Linq.Expressions;

namespace Payaka.Application.Services
{
    public class BaseService<TEntity, TRepository> : IBaseService<TEntity> where TEntity : BaseEntity where TRepository : IBaseRepository<TEntity>
    {
        private readonly IBaseService<TEntity> _repository;

        public BaseService(IBaseService<TEntity> repository)
        {
            _repository = repository;
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> where)
        {
            return await _repository.GetAllAsync(where);
        }

        public async Task<TEntity> GetById(Guid id)
        {
            return await _repository.GetById(id);
        }

        public async Task<TEntity> RemoveById(Guid id)
        {
            return await _repository.RemoveById(id);
        }
    }
}
