using Microsoft.AspNetCore.Mvc;

namespace MimaBookStore.Controllers
{
    public class AuthorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
