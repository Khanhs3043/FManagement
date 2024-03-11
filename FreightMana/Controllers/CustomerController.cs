using Microsoft.AspNetCore.Mvc;

namespace FreightMana.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
