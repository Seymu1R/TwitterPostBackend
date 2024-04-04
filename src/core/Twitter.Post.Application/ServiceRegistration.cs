using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Twitter.Post.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection collection)
        {
            var asmb = Assembly.GetExecutingAssembly();
            collection.AddAutoMapper(asmb);
            collection.AddMediatR(asmb);
            
            // collection.AddControllers()
            //     .AddFluentValidation(options =>
            //     {
            //         // Validate child properties and root collection elements
            //         options.ImplicitlyValidateChildProperties = true;
            //         options.ImplicitlyValidateRootCollectionElements = true;

            //         // Automatic registration of validators in assembly
            //         options.RegisterValidatorsFromAssembly(asmb);
            //     });
        }
    }
}