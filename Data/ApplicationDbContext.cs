using IMS.Models;
using IMS.Models.ResponseViewModels;
using IMS.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Net.Http.Headers;

namespace IMS.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions) 
        { }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);

            configurationBuilder.Properties<DateOnly>()
                .HaveConversion<DateOnlyConverter>()
                .HaveColumnType("date");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Consume API information and seed it into database
            Action<Task<FiltersResponse>> CountriesToModelAction = (content) =>
            {
                var filtersResponse = content.Result;
                List<Country> countriesResult = new List<Country>();
                foreach (var responseVal in filtersResponse.Countries)
                {
                    countriesResult.Add(new Country { Id = responseVal.Id, Name = responseVal.Country });
                }
                modelBuilder.Entity<Country>().HasData(countriesResult);
            };
            WebAPIConsume.ConsumeOnModelBuilding<Country, FiltersResponse>(
                $"films/filters",
                CountriesToModelAction);
            Action<Task<FiltersResponse>> GenresToModelAction = (content) =>
            {
                var filtersResponse = content.Result;
                List<Genre> genresResult = new List<Genre>();
                foreach (var responseVal in filtersResponse.Genres)
                {
                    genresResult.Add(new Genre { Id = responseVal.Id, Name = responseVal.Genre });
                }
                modelBuilder.Entity<Genre>().HasData(genresResult);
            };
            WebAPIConsume.ConsumeOnModelBuilding<Genre, FiltersResponse>(
                $"films/filters",
                GenresToModelAction);
        }
    }

    public class DateOnlyConverter : ValueConverter<DateOnly, DateTime>
    {
        public DateOnlyConverter() : base(
            d => d.ToDateTime(TimeOnly.MinValue),
            d => DateOnly.FromDateTime(d))
        { }
    }
}
