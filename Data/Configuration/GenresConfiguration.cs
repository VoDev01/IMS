using IMS.Models;
using IMS.Models.ResponseViewModels;
using APIConsumeService;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IMS.Data.Configuration
{
    public class GenresConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            Action<Task<FiltersResponse>> GenresToModelAction = (content) =>
            {
                var filtersResponse = content.Result;
                List<Genre> genresResult = new List<Genre>();
                foreach (var responseVal in filtersResponse.Genres)
                {
                    genresResult.Add(new Genre { Id = responseVal.Id, Name = responseVal.Genre });
                }
                builder.HasData(genresResult);
            };
            WebAPIConsume.ConsumeOnModelBuilding<Genre, FiltersResponse>(
                $"films/filters",
                GenresToModelAction);
        }
    }
}
