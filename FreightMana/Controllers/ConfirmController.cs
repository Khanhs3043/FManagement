using FreightMana.Models;
using Microsoft.AspNetCore.Mvc;

namespace FreightMana.Controllers
{
    public class ConfirmController : Controller
    {
        ManaFreightmentContext db = new ManaFreightmentContext();
        public IActionResult Index()
        {
            var orders = db.Orders
        .Select(o => new
        {
            o.Receiver.Name,
            o.Receiver.Address,
            o.Receiver.PhoneNumber,
            o.OrderId,
            o.Cod,
            o.Transport.Cost,
            o.Status
            
        })
        .ToList();
           // System.Diagnostics.Debug.WriteLine(orders[0].PhoneNumber);
           
            ViewBag.Orders = orders == null ? [] :orders;
            return View();
        }
        [HttpPost]
        public IActionResult Confirm(int orderId)
        {
            Order o = db.Orders.FirstOrDefault(o => o.OrderId == orderId);
            if (o.Status == "Đã nhập kho") o.Status = "Chờ xác nhận";
            else o.Status = "Đã nhập kho";
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        
    }
}
