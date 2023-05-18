using Microsoft.EntityFrameworkCore;
using Assignment2.Models;
using Assignment2.Service;

var builder = WebApplication.CreateBuilder(args);

// Add Cors
builder.Services.AddCors(options =>
{
    options.AddPolicy("MyPolicy", builder =>
    {
        builder.WithOrigins("*")
               .WithMethods("GET", "POST", "PUT", "DELETE")
               .WithHeaders("*");
    });
});

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddScoped<IToDoService, ToDoService>();
// Add database context
builder.Services.AddDbContextPool<ToDoContext>(
    (serviceProvider, options) => options.UseMySql(
        serviceProvider.GetRequiredService<IConfiguration>().GetConnectionString("DBConn"),
        new MySqlServerVersion(new Version(8, 0, 23))
    )
);

// Add Swagger/OpenAPI services


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

// Use CORS
app.UseCors("MyPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
