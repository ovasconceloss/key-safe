using DotNetEnv;
using back_end.Data;
using Microsoft.EntityFrameworkCore;

Env.Load();

var builder = WebApplication.CreateBuilder(args);

var dbHost = Environment.GetEnvironmentVariable("ConnectionStrings__DefaultConnection__Host");
var dbDatabase = Environment.GetEnvironmentVariable("ConnectionStrings__DefaultConnection__Database");
var dbUsername = Environment.GetEnvironmentVariable("ConnectionStrings__DefaultConnection__Username");
var dbPassword = Environment.GetEnvironmentVariable("ConnectionStrings__DefaultConnection__Password");

var connectionString = $"Host={dbHost}; Database={dbDatabase}; Username={dbUsername}; SSL Mode=VerifyFull; Channel Binding=Require; Password={dbPassword};";

builder.Configuration
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json")
    .AddEnvironmentVariables();

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseNpgsql(connectionString));

builder.Services.AddControllers();
builder.Services.AddOpenApi();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend", policy =>
    {
        policy.WithOrigins("http://localhost:5173")
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
