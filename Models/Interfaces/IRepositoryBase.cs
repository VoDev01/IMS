using IMS.Data;
using System.Linq.Expressions;

namespace IMS.Models.Interfaces
{
    public interface IRepositoryBase<T>
    {
        public IEnumerable<T> GetAll();
        public IEnumerable<T> GetAllWith(Expression<Func<T, bool>> filter);
        public IEnumerable<T> GetAllWith(Expression<Func<T, bool>> filter, string children);
        public IEnumerable<T> GetAllWith(string children);
        public IEnumerable<T> FindByCondition(Expression<Func<T, bool>> expression);
        public T GetByID(int id);
        public void Update(T entity);
        public void Create(T entity);
        public void Delete(T entity);
        public void Save();
    }
}
