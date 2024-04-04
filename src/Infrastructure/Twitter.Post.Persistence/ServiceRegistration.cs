using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Twitter.Post.Application.Interfaces.Repository;
using Microsoft.Extensions.Configuration;



namespace Twitter.Post.Persistance
{
    public static class ServiceRegistration
    {
        public static void AddPersistanceVoid(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("ProductsConnectionString");
            serviceCollection.AddDbContext<ApplicationDbContext>(options =>
             {
                options.UseMongoDB("mongodb://localhost:27017", "TwitterPost");
             });
            
            serviceCollection.AddScoped<IPostRepository, PostRepository>();       

        }
    }
}