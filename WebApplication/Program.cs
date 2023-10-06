using System.Data.SqlTypes;
using Microsoft.VisualBasic;
using WebApp = Microsoft.AspNetCore.Builder.WebApplication ;

var builder = WebApp.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<MySQLContext>();

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
