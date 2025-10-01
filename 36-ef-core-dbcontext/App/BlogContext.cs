using Microsoft.EntityFrameworkCore;

namespace App;

public class BlogContext : DbContext
{
    // TODO: Define a DbSet for Blog entities

    public BlogContext(DbContextOptions<BlogContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // TODO: Configure the DbContext to use an in-memory database named "Blogs"
        throw new NotImplementedException();
    }
}
