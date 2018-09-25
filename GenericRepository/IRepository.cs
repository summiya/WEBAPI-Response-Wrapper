using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepository
{
    public interface IRepository<T> where T : class
{
    T GetById(int id);
    IEnumerable<T> List();
    IEnumerable<T> List(Expression<Func<T, bool>> predicate);
    IEnumerable<T> ExecWithStoreProcedure(string query, params object[] parameters);
     void Add(T entity);
    void Delete(T entity);
    void Update(T entity , int Id);
    int CountRecords();
    List<T> GetPaginationRecords(int start, int offset,Expression<Func<T, bool>> predicate);
}
 
      public abstract class EntityBase        
        {
           public int Id { get; protected set; }
        }
}
