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

public class UserPreferenceRepository : Repository<UserPreference>, IUserPreferenceRepository
{
    private readonly ApplicationDbContext _db;
    public UserPreferenceRepository(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }



    public void Update(UserPreference obj)
    {
        _db.UserPreferences.Update(obj);
    }
}
