
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.EntityFrameworkCore.Extensions;
using Twitter.Post.Domain.Entities;


namespace TwitterPost.Persistance;

public class ApplicationDbContext : DbContext
{
    public DbSet<Post> Posts ;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Post>(b=> {
          b.ToCollection("posts");
          b.Property(c => c.Text).HasElementName("primaryName");
        });
    }

}

 