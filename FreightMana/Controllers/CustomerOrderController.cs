using Microsoft.AspNetCore.Mvc;

namespace FreightMana.Controllers
{
    public class CustomerOrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
