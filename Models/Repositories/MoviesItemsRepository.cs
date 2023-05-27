using IMS.Data;
using IMS.Models.Interfaces;
using RepositoryPattern.Repository;

namespace IMS.Models.Repositories
{
    public class MoviesItemsRepository : RepositoryBase<MoviePageItem>, IMoviesItems
    {
        public MoviesItemsRepository(ApplicationDbContext db) : base(db)
        {
        }
    }
}
