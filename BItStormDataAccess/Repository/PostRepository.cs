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

public class PostRepository : Repository<Post>, IPostRepository
{
    private readonly ApplicationDbContext _db;
    public PostRepository(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }



    public void Update(Post obj)
    {
        _db.Posts.Update(obj);
    }
}
