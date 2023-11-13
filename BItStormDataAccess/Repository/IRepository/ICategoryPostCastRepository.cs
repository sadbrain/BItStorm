using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace DataAccess.Repository.IRepository;

public interface ICategoryPostCastRepository : IRepository<CategoryPostCast>
{
    void Update(CategoryPostCast obj);
    IEnumerable<CategoryPostCast> GetAllByCategoryId(int categoryId);

}
