using IMS.Data;
using Microsoft.EntityFrameworkCore;
using IMS.Data;
using IMS.Models.Interfaces;
using System.Linq.Expressions;

namespace ShopProject.Models.Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected readonly ApplicationDbContext db;
        public RepositoryBase(ApplicationDbContext db)
        {
            this.db = db;
        }
        public IEnumerable<T> GetAll() => db.Set<T>();
        public IEnumerable<T> GetAllWith(Expression<Func<T, bool>> filter) => db.Set<T>().Where(filter);
        public IEnumerable<T> GetAllWith(Expression<Func<T, bool>> filter, string children) => db.Set<T>().Include(children).Where(filter);
        public IEnumerable<T> GetAllWith(string children) => db.Set<T>().Include(children);
        public IEnumerable<T> FindByCondition(Expression<Func<T, bool>> expression) => db.Set<T>().Where(expression);
        public T GetByID(int id) => db.Set<T>().AsEnumerable().ElementAt(id);
        public void Update(T entity) => db.Set<T>().Update(entity);
        public void Create(T entity) => db.Set<T>().Add(entity);
        public void Delete(T entity) => db.Set<T>().Remove(entity);
        public void Save() => db.SaveChanges();
    }
}
