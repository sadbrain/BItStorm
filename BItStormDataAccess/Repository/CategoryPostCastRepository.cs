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

public class CategoryPostCastRepository : Repository<CategoryPostCast>, ICategoryPostCastRepository
{
    private readonly ApplicationDbContext _db;
    public CategoryPostCastRepository(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }



    public void Update(CategoryPostCast obj)
    {
        _db.CategoryPostCasts.Update(obj);
    }
    public IEnumerable<CategoryPostCast> GetAllByCategoryId(int categoryId)
    {
        IEnumerable<CategoryPostCast> categoryPostCasts = _db.CategoryPostCasts.Where(c => c.CategoryId == categoryId);
        return categoryPostCasts.ToList();
    }
}
