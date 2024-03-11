using Microsoft.AspNetCore.Mvc;

namespace FreightMana.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
