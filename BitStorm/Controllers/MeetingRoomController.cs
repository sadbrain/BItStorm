using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BitStorm.Controllers;

public class MeetingRoomController : Controller
{
    // GET: MeetingRoomController
    public ActionResult Index()
    {
        return View();
    }


}