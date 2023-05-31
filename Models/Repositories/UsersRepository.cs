using IMS.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Repository;

namespace IMS.Models.Repositories
{
    public class UsersRepository : RepositoryBase<User>, IUsers
    {
        public UsersRepository(DbContext db) : base(db)
        {
        }
    }
}
