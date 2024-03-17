using Microsoft.AspNetCore.Mvc;

namespace FreightMana.Controllers
{
    public class LoginAdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
