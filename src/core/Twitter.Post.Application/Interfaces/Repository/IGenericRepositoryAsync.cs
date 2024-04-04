using Twitter.Post.Domain.Common;

namespace Twitter.Post.Application.Interfaces.Repository;

public interface IGenericRepositoryAsync<T> where T : BaseEntity
{
    Task<List<T>> GetAllAsync();
    Task<T> GetByIdAsync(string Id);
    Task<T> AddAsync(T entity);
}