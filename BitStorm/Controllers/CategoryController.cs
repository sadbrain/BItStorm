using DataAccess.Repository;
using DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using Models;
namespace BitStorm.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            List<Category> objCategories = _unitOfWork.Category.GetAll().ToList();
            return View(objCategories);
        }

    }
}
