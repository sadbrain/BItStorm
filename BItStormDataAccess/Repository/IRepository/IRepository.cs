using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.IRepository;

public interface IRepository<T> where T : class
{
    //T - model do CRUD operation
    //T - category
    IEnumerable<T> GetAll();
    //đầu vào kiểu T đầu ra kiểu bool
    //when you want a link operation this is the gerenal first and default
    T Get(Expression<Func<T, bool>> filter);
    void Add(T entity);
    void Remove(T entity);
    void RemoveRange(IEnumerable<T> entities);
}
