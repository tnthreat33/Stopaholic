using Microsoft.EntityFrameworkCore;
using Stopaholic.Server.Repositories;
using Stopaholic.Server.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configure Entity Framework and PostgreSQL
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IMonthlyListRepository, MonthlyListRepository>();
builder.Services.AddScoped<IMonthlyListService, MonthlyListService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    app.UseExceptionHandler("/Error"); // Error page for production
    app.UseHsts();                     // Use HSTS in production
}

app.UseHttpsRedirection();
app.UseStaticFiles();   // Serve static files (for Blazor)
app.UseRouting();

app.UseAuthorization();

app.MapControllers();
app.MapFallbackToFile("index.html");   // Fallback for Blazor to serve the app

app.Run();
