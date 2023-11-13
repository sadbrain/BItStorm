using DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace BitStorm.Controllers;

public class PostController : Controller
{
    private readonly IUnitOfWork _unitOfWork;
    public PostController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    public IActionResult Index()
    {
        //List<Post> objPosts = _unitOfWork.Post.GetAll().ToList();
        return View();
    }
    public IActionResult Create()
    {
        return PartialView();
    }
    [HttpPost]
    public IActionResult Create(Post post)
    {
    
        if (ModelState.IsValid)
        {
            _unitOfWork.Post.Add(post);
            _unitOfWork.Save();
            return RedirectToAction("Index");
}
        return View();
    }
}

