using DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace BitStorm.Controllers
{
    public class CommentController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public CommentController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult GetComments(int postId)    
        {
            var comments = _unitOfWork.Comment.GetAllByPostId(postId);

            return PartialView("_CommentList", comments);
        }
    }
}
