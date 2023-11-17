using DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using Models;
namespace BitStorm.Controllers
{
    public class BlogController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public BlogController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DetailVideo()
        {
            return View();
        }
        //public IActionResult DetailPostCast()
        //{
        //    return View();
        //}
        public IActionResult DisplayByOption(int? categoryId)
        {
            if(categoryId == null)
            {
                return NotFound();
            }
            
            var videoCategorys = _unitOfWork.CategoryVideo.GetAllByCategoryId(categoryId.Value);
            var postCastCategorys = _unitOfWork.CategoryPostCast.GetAllByCategoryId(categoryId.Value);
            List<Video> videos = new List<Video>();
            List<PostCast> postCasts = new List<PostCast>();
      
            foreach (var videoCategory in videoCategorys) { 
                Video video = _unitOfWork.Video.Get(v => v.Id == videoCategory.VideoId);
                videos.Add(video);
            }
            foreach (var postCastCategory in postCastCategorys)
            {
                PostCast postCast = _unitOfWork.PostCast.Get(pc => pc.Id == postCastCategory.PostCastId);
                postCasts.Add(postCast);
            }
            VideoPostCastVM viewModel = new VideoPostCastVM
            {
                Videos = videos,
                PostCasts = postCasts
            };
            return View(viewModel);
        }

    }
}
