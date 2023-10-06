using Microsoft.EntityFrameworkCore;

public class DatabaseContext : DbContext
{
    private readonly IConfiguration Configuration;
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        if (Configuration["DatabaseContext"] == "Oracle")
        {
            optionsBuilder.UseOracle(Configuration.GetConnectionString("OracleDatabase"));
        }
        else
        {
            var serverVersion = new MySqlServerVersion(new Version(8, 1, 0));
            optionsBuilder.UseMySql(Configuration.GetConnectionString("MySQLDatabase"), serverVersion);
        }

    }
    public DatabaseContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public DbSet<User>? Users { get; set; }
    public DbSet<Todo>? Todos { get; set; }
}
