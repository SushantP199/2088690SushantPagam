using System.Linq.Expressions;

namespace JWTinWebAPI.Models
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly EmployeeDbContext employeeDbContext;

        public GenericRepository()
        {
            employeeDbContext = new EmployeeDbContext();
        }

        public T Add(T item)
        {
            return employeeDbContext.Add(item).Entity;
        }

        public T Update(T item)
        {
            return employeeDbContext.Update(item).Entity;
        }

        public T Delete(T item)
        {
            return employeeDbContext.Remove(item).Entity;
        }

        public IReadOnlyList<T> Get(Expression<Func<T, bool>>? condition = null)
        {
            var data = employeeDbContext.Set<T>();

            return (condition == null) ? data.ToList() : data.Where(condition).ToList(); 
        }

        public async Task<int> SaveAsync()
        {
            return await employeeDbContext.SaveChangesAsync();
        }
    }
}
