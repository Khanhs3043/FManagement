using Microsoft.AspNetCore.Mvc;

namespace FreightMana.Controllers
{
    public class ListOrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
