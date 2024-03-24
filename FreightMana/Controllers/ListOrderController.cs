using FreightMana.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FreightMana.Controllers
{
    public class ListOrderController : Controller
    {
        ManaFreightmentContext db = new ManaFreightmentContext();
        private static List <Order> list;
        public IActionResult Index()
        {
            list = db.Orders
           .Where(o => o.Status != "Chờ xác nhận")
           .Include(o => o.Receiver)
           .Include(o => o.Transport)
           .ToList();
            // System.Diagnostics.Debug.WriteLine(orders[0].PhoneNumber);
            return View(list);
        }
        public ActionResult SaveStatus(List<Order> orders)
        {
     
            for(int i = 0;i< orders.Count; i++)
            {
                System.Diagnostics.Debug.WriteLine(list[i].OrderId);
                var order = db.Orders.Find(list[i].OrderId);
                order.Status = orders[i].Status;
                if(order.Status == "Đã hủy") order.CancelAt = DateTime.Now;
                if (order.Status == "Đã hoàn thành") order.CompleteAt = DateTime.Now;
                if (order.Status == "Đã nhập kho") order.ConfirmAt = DateTime.Now;
            }
            db.SaveChanges();

            
            return RedirectToAction("Index");
        }
    
        [HttpPost]
        public IActionResult Search(string keyword)
        {
            System.Diagnostics.Debug.WriteLine("searching");
            list = db.Orders.Where(o =>
                (o.OrderId.ToString().Contains(keyword) ||
                o.Receiver.Name.Contains(keyword) ||
                o.Receiver.PhoneNumber.Contains(keyword) ||
                o.Receiver.Address.Contains(keyword) ||
                o.Status.Contains(keyword)) &&
                o.Status != "Chờ xác nhận"
            )
                .Include(o => o.Receiver)
                .Include(o => o.Transport)
                .ToList();

            return View("Index", list);
        }
    }
}
