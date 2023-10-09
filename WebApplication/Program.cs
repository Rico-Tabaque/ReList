using System.Data.SqlTypes;
using Microsoft.VisualBasic;
using Microsoft.EntityFrameworkCore;
using WebApp = Microsoft.AspNetCore.Builder.WebApplication;

var builder = WebApp.CreateBuilder(args);

// Add services to the container.
// IConfiguration configuration = builder.Configuration;
// var serverVersion = new MySqlServerVersion(new Version(8, 1, 0));
// builder.Services.AddDbContext<DatabaseContext>(
//             (options) =>
//             {
//                 if (configuration["DatabaseContext"] == "Oracle")
//                 {
//                     options.UseOracle(configuration.GetConnectionString("OracleDatabase"));
//                 }
//                 else
//                 {
//                     options.UseMySql(configuration.GetConnectionString("MySQLDatabase"), serverVersion);
//                 }
//             });
builder.Services.AddDbContext<DatabaseContext>();

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
