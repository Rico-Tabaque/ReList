using System.Data.SqlTypes;
using Microsoft.VisualBasic;
using Microsoft.EntityFrameworkCore;
using WebApp = Microsoft.AspNetCore.Builder.WebApplication;

var builder = WebApp.CreateBuilder(args);

// Add services to the container.
var configuration = builder.Configuration;
var provider = configuration.GetValue("DatabaseProvider", "Oracle");
var serverVersion = new MySqlServerVersion(new Version(8, 1, 0));

builder.Services.AddDbContext<DatabaseContext>(
            options => _ = provider switch
            {
                "MySql" => options.UseMySql(configuration.GetConnectionString("MySqlDatabase"), serverVersion, x => x.MigrationsAssembly("MySqlMigrations")),
                "Oracle" => options.UseOracle(configuration.GetConnectionString("OracleDatabase"), x => x.MigrationsAssembly("OracleMigrations")),
                _ => throw new Exception($"Unsuported provider: {provider}")
            }
        );

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
