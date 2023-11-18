using Microsoft.AspNetCore.Mvc;

namespace NetMVC.Controllers
{
    public class UserController : Controller
    {
       public IActionResult Info() {
            return View();
       }
    }
}