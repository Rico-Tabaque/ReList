using System.Data.SqlTypes;
using Microsoft.VisualBasic;
using WebApp = Microsoft.AspNetCore.Builder.WebApplication ;

var builder = WebApp.CreateBuilder(args);

// Add services to the container.
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

app.MapGet("/", () => "Hello World!");

var sampleList = new int[] { 1, 2, 3, 4, 5 };

app.MapGet("/test", () => sampleList);
app.MapPost("/createTodo", () => sampleList);


app.MapPost("/user", (User user, DatabaseContext databaseContext) =>
{
    //var newUser = new User() { Id = 1, FamilyName = "Arroyo", GivenName = "Exequiel", Gender = "Male" };
    
    databaseContext.Users.Add(user);
    databaseContext.SaveChanges();

    return Results.Created("/user", user);
});

app.Run();
