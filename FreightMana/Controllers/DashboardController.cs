using Microsoft.AspNetCore.Mvc;

namespace FreightMana.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
