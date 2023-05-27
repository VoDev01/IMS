using IMS.Data;
using IMS.Models.Interfaces;
using RepositoryPattern.Repository;

namespace IMS.Models.Repositories
{
    public class MoviesPagesRepository : RepositoryBase<MoviePage>, IMoviesPages
    {
        public MoviesPagesRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}
