using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebHelpdeskApi.Models;

namespace WebHelpdeskApi.Controllers
{
    public class LoginController : Controller
    {
       

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Logout()
        {
            return View();
        }

       
    }
}
