using Microsoft.EntityFrameworkCore;
using Twitter.Post.Application.Interfaces.Repository;
using Twitter.Post.Domain.Common;

namespace TwitterPost.Persistance;

public class GenericRepostory<T> : IGenericRepositoryAsync<T> where T : BaseEntity
{
    private ApplicationDbContext context;

    public GenericRepostory(ApplicationDbContext context)
    {
        this.context = context;
    }
    public async Task<T> AddAsync(T entity)
    {   
        await context.Set<T>().AddAsync(entity);
        await context.SaveChangesAsync();
        return entity;
    }

    public async Task<List<T>> GetAllAsync()
    {
        return await context.Set<T>().ToListAsync();
    }

    public async Task<T> GetByIdAsync(string Id)
    {      
        return await context.Set<T>().FindAsync(Id);
    }
}

