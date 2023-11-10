using DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace BitStorm.Controllers
{
    public class ContactExpertController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public ContactExpertController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }
    }
}
