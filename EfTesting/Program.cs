using EfTesting.DbContext;
using EfTesting.Interfaces;
using EfTesting.Repository;
using EfTesting.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Logging;
using System.Text.Json.Serialization;

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
builder.Services.AddScoped<IFormBaseRepository, FormBaseRepository>();
builder.Services.AddScoped<IForm99Repository, Form99Repository>();
builder.Services.AddScoped<IFormSchARepository, FormSchARepository>();
builder.Services.AddScoped<IFormSchA2Repository, FormSchA2Repository>();

builder.Services.AddScoped<FormBaseService>();
builder.Services.AddScoped<Form99Service>();
builder.Services.AddScoped<FormSchAService>();
builder.Services.AddScoped<FormSchA2Service>();

builder.Services.AddControllers().AddJsonOptions(options =>
    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter())
);

// Add services to the container.
builder.Services.AddRazorPages();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.Configure<RouteOptions>(options =>
{
    options.LowercaseUrls = true;
    options.LowercaseQueryStrings = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    IdentityModelEventSource.ShowPII = true;
}
app.UseStaticFiles();

//app.UseRouting();

app.UseAuthorization();

//app.MapRazorPages();

app.MapControllers();

app.Run();
