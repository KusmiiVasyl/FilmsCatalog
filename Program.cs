using KR.Repositories;
using KR.Interfaces;
using Microsoft.EntityFrameworkCore;
using KR.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddScoped<IFilmRepository, FilmRepository>();
builder.Services.AddScoped<IFilmService, FilmService>();

var databaseConnectionString = builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContext<SakilaDbContext>(option =>
        option.UseSqlServer(databaseConnectionString));


var app = builder.Build();

await DbInitializer.InitializeDataBaseAsync(app);

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
