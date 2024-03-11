using FreightMana.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FreightMana.Controllers
{
	public class DashboardController : Controller
    {
		ManaFreightmentContext db = new ManaFreightmentContext();
		public IActionResult Index()
        {
			var totalRevenue = db.Orders.Sum(o => o.TransportFee);
			ViewBag.TotalRevenue = totalRevenue;

			// Tính tổng số đơn hàng
			int totalOrders = db.Orders.Count();
			ViewBag.TotalOrders = totalOrders;

			// Tính tổng số đơn hàng đã giao
			int deliveredOrders = db.Orders.Count(o => o.Status == "Đã nhận hàng");
			ViewBag.DeliveredOrders = deliveredOrders;

			// Tính tổng số đơn hàng đã hủy
			int cancelledOrders = db.Orders.Count(o => o.Status == "Hủy đơn");
			ViewBag.CancelledOrders = cancelledOrders;

			// Tính tổng số đơn hàng chưa giao
			int pendingOrders = db.Orders.Count(o => o.Status != "Đã nhận hàng" && o.Status != "Hủy đơn" && o.Status != "Chờ xác nhận");
			ViewBag.PendingOrders = pendingOrders;
			return View();
        }
    }
}
