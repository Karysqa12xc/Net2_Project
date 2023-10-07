using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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