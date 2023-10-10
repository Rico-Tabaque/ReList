using Microsoft.EntityFrameworkCore;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {

    }

    public DbSet<User>? Users { get; set; }
    public DbSet<Todo>? Todos { get; set; }
}
