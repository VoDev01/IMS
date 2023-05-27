using IMS.Data;
using IMS.Models.Interfaces;
using RepositoryPattern.Repository;

namespace IMS.Models.Repositories
{
    public class CountriesRepository : RepositoryBase<Country>, ICountries
    {
        public CountriesRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}
