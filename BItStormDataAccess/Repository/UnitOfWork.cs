using DataAccess.Data;
using DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _db;
  

    public ICategoryRepository Category { get; private set; }

    public IUserRepository User { get; private set; }

    public IExpertRepository Expert { get; private set; }
    public IUserPreferenceRepository UserPreference { get; private set; }

    public IVideoRepository Video { get; private set; }
    public ICategoryVideoRepository CategoryVideo { get; private set; }

    public IPostRepository Post { get; private set; }

    public ICommentRepository Comment { get; private set; }
    public IPostCastRepository PostCast { get; private set; }

    public ICategoryPostCastRepository CategoryPostCast { get; private set; }
    public IMeetingRoomRepository MeetingRoom { get; private set; }

    public UnitOfWork(ApplicationDbContext db)
    {
        _db = db;
        Category = new CategoryRepository(_db);
        User = new UserRepository(_db);
        Expert = new ExpertRepository(_db);
        UserPreference = new UserPreferenceRepository(_db);
        Video = new VideoRepository(_db);
        CategoryVideo = new CategoryVideoRepository(_db);
        Post = new PostRepository(_db);
        Comment = new CommentRepository(_db);
        PostCast = new PostCastRepository(_db);
        CategoryPostCast = new CategoryPostCastRepository(_db);
        MeetingRoom = new MeetingRoomRepository(_db);
    }
    public void Save()
    {
        _db.SaveChanges();
    }

    void IUnitOfWork.Save()
    {
        throw new NotImplementedException();
    }
}
