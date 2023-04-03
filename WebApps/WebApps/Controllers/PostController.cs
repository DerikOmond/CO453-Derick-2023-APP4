using Microsoft.AspNetCore.Mvc;

namespace WebApps.Controllers
{
    public class PostController : Controller
    {
        public IActionResult Posts()
        {
            return View();
        }
    }
}
