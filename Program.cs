using Microsoft.EntityFrameworkCore;
using IMS.Controllers;
using IMS.Data;
using IMS.Models.Interfaces;
using IMS.Models.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(
    builder.Configuration.
    GetConnectionString("Default")));

builder.Services.AddScoped<IMoviesPages, MoviesPagesRepository>();
builder.Services.AddScoped<IMoviesItems, MoviesItemsRepository>();
builder.Services.AddScoped<ICountries, CountriesRepository>();
builder.Services.AddScoped<IGenres, GenresRepository>();

builder.Services.AddLogging(logging => logging.AddConsole());
builder.Services.AddSingleton<Logger<MoviesController>>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
