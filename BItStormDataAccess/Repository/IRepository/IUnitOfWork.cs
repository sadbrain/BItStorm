using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.IRepository;

public interface IUnitOfWork
{
    ICategoryRepository Category { get; }
    IUserRepository User { get; }
    IExpertRepository Expert { get; }
    IUserPreferenceRepository UserPreference { get; }
    IVideoRepository Video { get; }
    ICategoryVideoRepository CategoryVideo { get; }
    IPostRepository Post { get; }
    ICommentRepository Comment { get; }
    IPostCastRepository PostCast { get; }
    ICategoryPostCastRepository CategoryPostCast { get; }
    IMeetingRoomRepository MeetingRoom { get; } 

    void Save();
}
