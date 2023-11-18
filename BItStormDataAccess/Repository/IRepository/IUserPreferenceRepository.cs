using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace DataAccess.Repository.IRepository;

public interface IUserPreferenceRepository : IRepository<UserPreference>
{
    void Update(UserPreference obj);
    IEnumerable<UserPreference> GetAllByUserId(int userId);


}
