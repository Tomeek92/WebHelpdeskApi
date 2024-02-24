using Microsoft.AspNetCore.Mvc;

namespace WebHelpdeskApi.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Delete(Guid id)
        {
            return View();
        }
    }
}
