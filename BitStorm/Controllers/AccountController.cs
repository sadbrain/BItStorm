using DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using Models;
namespace BitStorm.Controllers;

public class AccountController : Controller
{
    private readonly IUnitOfWork _unitOfWork;

    public AccountController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Login()
    {
        return View();
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Login(User obj)
    {

        User user = _unitOfWork.User.Get(u => u.Password == obj.Password && u.Email == obj.Email);
        if(user != null)
        {
            Response.Cookies.Append("UserId", user.Id.ToString());
            UserPreference up = _unitOfWork.UserPreference.Get(u => u.UserId == user.Id);
            if(up != null)
            {
                return RedirectToAction("Index", "Home");


            }
            else
            {
                return RedirectToAction("FormReference");

            }

        }
        else
        {

            ModelState.AddModelError("", "Tên đăng nhập hoặc mật khẩu không đúng.");
            return View(obj);
        }
        //Session["UserID"] = obj.Id.ToString();
        //Session["UserName"] = obj.Name.ToString();

    }


    public IActionResult Register() 
    {
        return View();  
    }
    [HttpPost]
    [ValidateAntiForgeryToken]

    public IActionResult Register(User obj)
    {
  
            // Gọi hàm đăng ký từ dịch vụ người dùng
        User user = _unitOfWork.User.Get(u =>  u.Email == obj.Email);
        if (user == null)
        {
            obj.RoleId = 1;
            obj.Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRnfoRLDgUkFrFW68UD_RvX0SXOF9L7jKxVaQ&usqp=CAU";
            _unitOfWork.User.Add(obj);
            _unitOfWork.Save();
            User user2= _unitOfWork.User.Get(u => u.Email == obj.Email);
            return RedirectToAction("Login", "Account");
        }
        else
        {
            ModelState.AddModelError("", "tài khoản đã có trong hệ thống của chúng tôi");

            return View(obj);
        }
    }
    public IActionResult FormReference()
    {
        List<Category> categories = _unitOfWork.Category.GetAll().ToList();
        ViewBag.categories = categories;
        return View();
    }
    [HttpPost]
    [ValidateAntiForgeryToken]

    public IActionResult FormReference(IFormCollection form)
    {
        int.TryParse(Request.Cookies["UserId"], out int userId);
        foreach (string key in form.Keys)
        {

            var category = _unitOfWork.Category.Get(c => c.Name == key);
            if (category != null)
            {
                UserPreference up = new UserPreference
                {
                    CategoryId = category.Id,
                    UserId = userId,
                };
                _unitOfWork.UserPreference.Add(up);
                _unitOfWork.Save();
            }
        }
        return RedirectToAction("Index", "Home");

    }

    public IActionResult Logout()
    {
        //Session["UserId"] = null;

        // Chuyển hướng đến trang đăng nhập hoặc trang khác
        Response.Cookies.Delete("UserId");
        return RedirectToAction("Index", "Home");
    }
}
