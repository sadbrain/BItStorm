using DataAccess.Data;
using DataAccess.Repository.IRepository;
using Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository;

public class CommentRepository : Repository<Comment>, ICommentRepository
{
    private readonly ApplicationDbContext _db;
    public CommentRepository(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }



    public void Update(Comment obj)
    {
        _db.Comments.Update(obj);
    }
    public IEnumerable<Comment> GetAllByPostId(int postId)
    {
        IEnumerable<Comment> comments = _db.Comments.Where(c => c.PostId == postId);
        return comments.ToList();
    }
}
