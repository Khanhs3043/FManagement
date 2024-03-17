using FreightMana.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FreightMana.Controllers
{
    public class ConfirmController : Controller
    {
        ManaFreightmentContext db = new ManaFreightmentContext();
        public IActionResult Index()
        {
            List<Order> orders = new List<Order>() { };
            orders = db.Orders
            .Where(o => o.Status == "Chờ xác nhận")
            .Include(o => o.Receiver)
            .Include(o => o.Transport)
            .ToList();
            
            return View(orders);
        }
        [HttpPost]
        public IActionResult Confirm(List<String> statusList)
        {
            List<Order> list = db.Orders.Where(o => o.Status == "Chờ xác nhận").ToList();
            for (int i = 0; i < list.Count;i++)
            {
                list[i].Status = statusList[i];
                list[i].ConfirmAt = DateTime.Now;
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
                o.Status == "Chờ xác nhận"
            )
                .Include(o => o.Receiver)
                .Include(o => o.Transport)
                .ToList();

            return View("Index", orders);
        }
    }
}
