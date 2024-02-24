using Microsoft.AspNetCore.Mvc;

namespace WebHelpdeskApi.Controllers
{
    public class HelpdeskController : Controller
    {
        public IActionResult ViewTask()
        {
            return View();
        }
    }
}
