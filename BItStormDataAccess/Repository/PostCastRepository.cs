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

public class PostCastRepository : Repository<PostCast>, IPostCastRepository
{
    private readonly ApplicationDbContext _db;
    public PostCastRepository(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }
    public void Update(PostCast obj)
    {
        _db.PostCasts.Update(obj);
    }

}
