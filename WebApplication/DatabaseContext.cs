using Microsoft.EntityFrameworkCore;

public class DatabaseContext : DbContext
{
    public DbSet<User>? Users { get; set; }
    public DbSet<Todo>? Todos { get; set; }
    private readonly IConfiguration Configuration;
    public DatabaseContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseOracle(Configuration.GetConnectionString("OracleDatabase"));
    }
}