using IMS.Data;
using IMS.Models.Interfaces;
using RepositoryPattern.Repository;

namespace IMS.Models.Repositories
{
    public class GenresRepository : RepositoryBase<Genre>, IGenres
    {
        public GenresRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}
