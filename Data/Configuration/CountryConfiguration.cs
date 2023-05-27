using IMS.Models;
using IMS.Models.ResponseViewModels;
using APIConsumeService;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IMS.Data.Configuration
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            Action<Task<FiltersResponse>> CountriesToModelAction = (content) =>
            {
                var filtersResponse = content.Result;
                List<Country> countriesResult = new List<Country>();
                foreach (var responseVal in filtersResponse.Countries)
                {
                    countriesResult.Add(new Country { Id = responseVal.Id, Name = responseVal.Country });
                }
                builder.HasData(countriesResult);
            };
            WebAPIConsume.ConsumeOnModelBuilding<Country, FiltersResponse>(
                $"films/filters",
                CountriesToModelAction);
        }
    }
}
