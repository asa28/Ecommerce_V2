using Microsoft.AspNetCore.Mvc;

namespace V2.Website.Controllers
{
    public class UserController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }


    }
}
