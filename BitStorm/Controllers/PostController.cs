using DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

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
        List<Post> objPosts = _unitOfWork.Post.GetAll().ToList();

        foreach (var item in objPosts)
        {
            item.User  = _unitOfWork.User.Get(u => u.Id == item.UserId);

        }
        return View(objPosts);
    }
    
    public IActionResult Create(int idUser, string content, bool isAnonymous)
    {
        Post post = new Post
        {
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now,
            LikeCount = 0,
            CommentCount = 0,
            IsAnonymous = isAnonymous,
            Content = content,
            UserId = idUser
        };
        _unitOfWork.Post.Add(post);
        _unitOfWork.Save();
        ViewBag.isAnonymous = isAnonymous;
        return RedirectToAction("Index");
    }
}

