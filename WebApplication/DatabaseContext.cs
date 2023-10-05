using Microsoft.EntityFrameworkCore;

public class DatabaseContext : DbContext
{
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseOracle(@"User Id=system;Password=orcladmin;Data Source=localhost/xe;");
    }
}