using FreightMana.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FreightMana.Controllers
{
    public class ListOrderController : Controller
    {
        ManaFreightmentContext db = new ManaFreightmentContext();
        public IActionResult Index()
        {
            var orders = db.Orders
           .Where(o => o.Status != "Chờ xác nhận")
           .Include(o => o.Receiver)
           .Include(o => o.Transport)
           .ToList();
            // System.Diagnostics.Debug.WriteLine(orders[0].PhoneNumber);
            return View(orders);
        }
        public ActionResult SaveStatus(List<Order> orders)
        {
            List<Order> list = db.Orders.Where(o => o.Status != "Chờ xác nhận").ToList();
     
            for(int i = 0;i< orders.Count; i++)
            {
                list[i].Status = orders[i].Status;
                if(list[i].Status == "Đã hủy") list[i].CancelAt = DateTime.Now;
                if (list[i].Status == "Đã hoàn thành") list[i].CompleteAt = DateTime.Now;
                if (list[i].Status == "Đã nhập kho") list[i].ConfirmAt = DateTime.Now;
            }
            db.SaveChanges();

            
            return RedirectToAction("Index");
        }
    
        [HttpPost]
        public IActionResult Search(string keyword)
        {
            System.Diagnostics.Debug.WriteLine("searching");
            var orders = db.Orders.Where(o =>
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

            return View("Index", orders);
        }
    }
}
