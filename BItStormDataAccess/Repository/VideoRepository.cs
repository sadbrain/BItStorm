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

public class VideoRepository : Repository<Video>, IVideoRepository
{
    private readonly ApplicationDbContext _db;
    public VideoRepository(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }



    public void Update(Video obj)
    {
        _db.Videos.Update(obj);
    }
}
