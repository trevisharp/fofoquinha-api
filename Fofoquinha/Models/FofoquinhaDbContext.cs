using Microsoft.EntityFrameworkCore;

namespace Fofoquinha.Models;

public class FofoquinhaDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Profile> Profiles => Set<Profile>();
    public DbSet<Post> Posts => Set<Post>();

    protected override void OnModelCreating(ModelBuilder model)
    {
        model.Entity<Profile>();

        model.Entity<Post>()
            .HasOne(p => p.Author)
            .WithMany(p => p.Posts)
            .HasForeignKey(p => p.ProfileID)
            .OnDelete(DeleteBehavior.Cascade);
    }
}