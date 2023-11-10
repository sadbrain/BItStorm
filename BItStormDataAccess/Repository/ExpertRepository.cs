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

public class ExpertRepository : Repository<Expert>, IExpertRepository
{
    private readonly ApplicationDbContext _db;
    public ExpertRepository(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }

    public void Update(Expert obj)
    {
        _db.Experts.Update(obj);
    }
}
