using Microsoft.EntityFrameworkCore;

public class DatabaseContext : DbContext
{
    // IConfiguration Configuration;
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        string[] arguments = Environment.GetCommandLineArgs();
        System.Console.WriteLine(arguments.GetValue(24).ToString().ToLower());
        System.Console.WriteLine(arguments.GetValue(25).ToString().ToLower());
        if (arguments.GetValue(24).ToString().ToLower() == "oracle")
        {
            // optionsBuilder.UseOracle(Configuration.GetConnectionString("OracleDatabase"));
            optionsBuilder.UseOracle(arguments.GetValue(25).ToString(), x => x.MigrationsAssembly("OracleMigrations"));
        }
        else
        {
            var serverVersion = new MySqlServerVersion(new Version(8, 1, 0));
            // optionsBuilder.UseMySql(Configuration.GetConnectionString("MySQLDatabase"), serverVersion);
            optionsBuilder.UseMySql(arguments.GetValue(25).ToString(), serverVersion , x => x.MigrationsAssembly("MySqlMigrations"));
        }
    }

    public DbSet<User>? Users { get; set; }
    public DbSet<Todo>? Todos { get; set; }
}
