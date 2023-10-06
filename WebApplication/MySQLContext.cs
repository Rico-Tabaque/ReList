
using Microsoft.EntityFrameworkCore;

public class MySQLContext : DbContext
{
    public DbSet<User>? Users { get; set; }
    public DbSet<Todo>? Todos { get; set; }
    private readonly IConfiguration Configuration;
    public MySQLContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        var serverVersion = new MySqlServerVersion(new Version(8, 1, 0));
        optionsBuilder.UseMySql(Configuration.GetConnectionString("MySQLDatabase"), serverVersion);
    }
}
