using DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

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

    }
}
