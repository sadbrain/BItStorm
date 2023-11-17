using DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace BitStorm.Controllers
{
   
    public class UserProfileController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserProfileController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
