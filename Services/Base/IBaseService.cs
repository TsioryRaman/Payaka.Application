using Payaka.Domain.Base;
using System.Linq.Expressions;

namespace Payaka.Application.Services.Base
{
    public interface IBaseService<T> where T : BaseEntity
    {
        Task<T> GetById(Guid id);
        Task<List<T>> GetAllAsync();
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> where);
        Task<T> RemoveById(Guid id);
    }
}
