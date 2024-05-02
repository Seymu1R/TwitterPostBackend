using Microsoft.EntityFrameworkCore;
using Twitter.Post.Application.Interfaces.Repository;
using Twitter.Post.Domain.Common;

namespace Twitter.Post.Persistance;

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
        return await context.Set<T>().AsNoTracking().ToListAsync();
    }

    public async Task<T> GetByIdAsync(string Id)
    {      
        return await context.Set<T>().FindAsync(Id);
    }
    public async Task<T> UpdateAsync(T entity)
    {
        var existData =  await  context.Set<T>().AsNoTracking().FirstOrDefaultAsync(x=> x._id == entity._id);
        context.Set<T>().Update(entity);
        await context.SaveChangesAsync();
        return existData;
    }

    public async Task DeleteItemAsync(string Id)
    {
       var item = await context.Set<T>().FindAsync(Id) ?? throw new Exception("Post is null");
       context.Set<T>().Remove(item);

       await context.SaveChangesAsync();
    }   
}

