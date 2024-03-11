using FreightMana.Models;
using Microsoft.AspNetCore.Mvc;

namespace FreightMana.Controllers
{
    public class CreateOrderController : Controller
    {
        ManaFreightmentContext db = new ManaFreightmentContext();
        public IActionResult Index()
        {
            return View();
        }
    }
}
