using Microsoft.AspNetCore.Mvc;

namespace BitStorm.Controllers
{
    public class PostCastController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DetailPostCast()
        {
            return View();
        }   
    }
}
