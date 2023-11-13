using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace DataAccess.Repository.IRepository;

public interface ICategoryVideoRepository : IRepository<CategoryVideo>
{
    void Update(CategoryVideo obj);
    IEnumerable<CategoryVideo> GetAllByCategoryId(int categoryId);

}
