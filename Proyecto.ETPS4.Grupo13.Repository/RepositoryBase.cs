using Microsoft.EntityFrameworkCore;
using Proyecto.ETPS4.Grupo13.Repository.Contracts;
using System.Linq.Expressions;

namespace Proyecto.ETPS4.Grupo13.Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected RepositoryContext _context;
        public RepositoryBase(RepositoryContext context) => _context = context;
        public IQueryable<T> FindAll(bool trackChanges) =>
            !trackChanges ? _context.Set<T>().AsNoTracking() : _context.Set<T>();

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> condition, bool trackChanges) =>
            !trackChanges ? _context.Set<T>().Where(condition).AsNoTracking() : _context.Set<T>().Where(condition);

        public void Create(T entity) => _context.Set<T>().Add(entity);
        public void Update(T entity) => _context.Set<T>().Update(entity);
        public void Delete(T entity) => _context.Set<T>().Remove(entity);
        public void DeleteRange(ICollection<T> entities) => _context.RemoveRange(entities);
    }
}
