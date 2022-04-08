using EfTesting.DbContext;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<FecContext>(
    cfg =>
    {
        // There's a perf cost to this so let's do it only in lower environments
        cfg.EnableDetailedErrors();

        if (!cfg.IsConfigured)
        {
            cfg.UseSqlServer("server=(local);Initial Catalog=EntityFrameworkTest;Integrated Security=True;");
        }
    }
);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
