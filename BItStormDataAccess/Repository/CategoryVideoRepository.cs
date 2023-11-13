using DataAccess.Data;
using DataAccess.Repository.IRepository;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository;

public class CategoryVideoRepository : Repository<CategoryVideo>, ICategoryVideoRepository
{
    private readonly ApplicationDbContext _db;
    public CategoryVideoRepository(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }



    public void Update(CategoryVideo obj)
    {
        _db.CategoryVideos.Update(obj);
    }
    public IEnumerable<CategoryVideo> GetAllByCategoryId(int categoryId)
    {
        IEnumerable<CategoryVideo> categoryVideos = _db.CategoryVideos.Where(c => c.CategoryId == categoryId);
        return categoryVideos.ToList();
    }
}
