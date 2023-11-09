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

public class MeetingRoomRepository : Repository<MeetingRoom>, IMeetingRoomRepository
{
    private readonly ApplicationDbContext _db;
    public MeetingRoomRepository(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }



    public void Update(MeetingRoom obj)
    {
        _db.MeetingRooms.Update(obj);
    }
}
