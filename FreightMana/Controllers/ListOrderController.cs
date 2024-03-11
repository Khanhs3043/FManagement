using FreightMana.Models;
using Microsoft.AspNetCore.Mvc;

namespace FreightMana.Controllers
{
    public class ListOrderController : Controller
    {
        ManaFreightmentContext db = new ManaFreightmentContext();
        public IActionResult Index()
        {
            var orders = db.Orders
           .Where(o => o.Status != "Chờ xác nhận")
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

            ViewBag.Orders = orders == null ? [] : orders;
            return View();
        }
        public ActionResult SaveStatus(List<Order> orders)
        {
            List<Order> list = db.Orders.Where(o => o.Status != "Chờ xác nhận").ToList();
     
            for(int i = 0;i< orders.Count; i++)
            {
                list[i].Status = orders[i].Status;
            }
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
