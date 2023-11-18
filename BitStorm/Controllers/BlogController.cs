using DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using Models;
using System.Xml.Linq;

namespace BitStorm.Controllers;


public class BlogController : Controller
{
    private readonly IUnitOfWork _unitOfWork;
    public BlogController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    public IActionResult Index()
    {
        List<Category> categories = _unitOfWork.Category.GetAll().ToList();
        ViewBag.categories = categories;
        if (int.TryParse(Request.Cookies["UserId"], out int userId)) 
       {
            List<UserPreference> ups = _unitOfWork.UserPreference.GetAllByUserId(userId).ToList();
            if(ups  != null)
            {
                List<Video> videos1 = new List<Video>();
                List<PostCast> postCasts = new List<PostCast>();
                foreach (var up in ups)
                {
                    int categoryId = up.CategoryId;
                    var videoCategorys = _unitOfWork.CategoryVideo.GetAllByCategoryId(categoryId);
                    var postCastCategorys = _unitOfWork.CategoryPostCast.GetAllByCategoryId(categoryId);

                    foreach (var videoCategory in videoCategorys)
                    {
                        Video video = _unitOfWork.Video.Get(v => v.Id == videoCategory.VideoId);
                        videos1.Add(video);
                    }
                    foreach (var postCastCategory in postCastCategorys)
                    {
                        PostCast postCast = _unitOfWork.PostCast.Get(pc => pc.Id == postCastCategory.PostCastId);
                        postCasts.Add(postCast);
                    }


                }

                VideoPostCastVM viewModel1 = new VideoPostCastVM
                {
                    Videos = videos1,
                    PostCasts = postCasts
                };
                return View(viewModel1);


            }
 
        }

        List<Video> videos = _unitOfWork.Video.GetAll().ToList();
        List<PostCast> podcasts = _unitOfWork.PostCast.GetAll().ToList();

        VideoPostCastVM viewModel = new VideoPostCastVM
        {
            Videos = videos,
            PostCasts = podcasts
        };
        return View(viewModel);



    }
    public IActionResult DetailVideo(int? id)
    {
        if (id == 0 || id == null)
        {
            return NotFound();
        }
        var video = _unitOfWork.Video.Get(v => v.Id == id);
        return View(video);
    }
    //public IActionResult DetailPostCast()
    //{
    //    return View();
    //}
    public IActionResult DisplayByOption(int? id)
    {

        if (id == 0 || id == null)
        {
            return NotFound();
        }
        var videoCategorys = _unitOfWork.CategoryVideo.GetAllByCategoryId(id.Value);
        var postCastCategorys = _unitOfWork.CategoryPostCast.GetAllByCategoryId(id.Value);
        List<Category> categories = _unitOfWork.Category.GetAll().ToList();
        ViewBag.categories = categories;
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
