using DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace BitStorm.Controllers
{
    public class AboutUsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public AboutUsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
