using FreightMana.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http; // Đảm bảo thêm namespace này để sử dụng HttpContext.Session

namespace FreightMana.Controllers
{
    public class CustomerController : Controller
    {
        ManaFreightmentContext db = new ManaFreightmentContext();
        public IActionResult Index()
        {
            // Lấy id của người dùng từ Session
            var userId = HttpContext.Session.GetInt32("UserId");

            // Kiểm tra nếu không có id hoặc người dùng không đăng nhập
            if (userId == null)
            {
                // Xử lý khi người dùng chưa đăng nhập, ví dụ: chuyển hướng đến trang đăng nhập
                return RedirectToAction("Index", "LoginCustomer");
            }

            // Truy vấn cơ sở dữ liệu để lấy thông tin người dùng từ id
            var user = db.CusAccounts.Find(userId);

            // Kiểm tra nếu không tìm thấy người dùng hoặc thông tin người dùng không hợp lệ
            if (user == null)
            {
                // Xử lý khi không tìm thấy thông tin người dùng, ví dụ: hiển thị thông báo lỗi
                ViewBag.ErrorMessage = "Không tìm thấy thông tin người dùng!";
            }
            else
            {
                // Lấy tên người dùng từ thông tin người dùng
                var userName = user.Username;

                // Truyền tên người dùng sang view để hiển thị
                ViewBag.UserName = userName;
            }
            var ConfirmAt = db.Orders.Select(o=>o.OrderId);
            ViewBag.ConfirmAt = ConfirmAt;

            return View();
        }
    }
}
