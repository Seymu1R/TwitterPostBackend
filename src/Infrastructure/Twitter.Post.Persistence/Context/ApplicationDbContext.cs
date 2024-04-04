
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.EntityFrameworkCore.Extensions;
using Twitter.Post.Domain.Entities;


namespace Twitter.Post.Persistance;

public class ApplicationDbContext : DbContext
{
    public DbSet<Twitter.Post.Domain.Entities.Post> Posts ;

     public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
     {

     }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
       
        modelBuilder.Entity<Twitter.Post.Domain.Entities.Post>()
        .Property(e => e._id)
        .ValueGeneratedOnAdd();
    }

}

 