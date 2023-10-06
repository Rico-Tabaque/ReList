using Microsoft.EntityFrameworkCore;

public class OracleContext : DbContext
{
    public DbSet<User>? Users { get; set; }
    public DbSet<Todo>? Todos { get; set; }
    private readonly IConfiguration Configuration;
    public OracleContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseOracle(Configuration.GetConnectionString("OracleDatabase"));
    }
}
