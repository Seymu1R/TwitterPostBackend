using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using Twitter.Post.Application.Interfaces.Repository;
using Twitter.Post.Domain.Models;
using TwitterPost.Persistance;
using Twitter.Post.Application;
public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddPersistanceVoid(builder.Configuration);
            builder.Services.AddApplicationServices();
            

            var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";


                // builder.Services.AddDbContext<ApplicationDbContext>(options => {
                //    options.UseMongoDB("mongodb://localhost:27017", "TwitterPostApi");
                // });     

    

         
            
            builder.Services.AddCors(options =>
            {
                options.AddPolicy(MyAllowSpecificOrigins,
                                      policy =>
                                      {
                                          policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();

                                      });
            });

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseCors(MyAllowSpecificOrigins);

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
        

    