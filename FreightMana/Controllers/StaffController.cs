using FreightMana.Models;
using Microsoft.AspNetCore.Mvc;

namespace FreightMana.Controllers
{
    public class StaffController : Controller
    {
        ManaFreightmentContext db = new ManaFreightmentContext();
        public IActionResult Index()
        {
            var listStaff = db.Staffs.ToList();
            ViewBag.staffList = listStaff;
            return View();
        }
        public ActionResult Confirm(Staff staff)
        {
            staff.WarehouseId = 1;
            db.Staffs.Add(staff);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            Staff staff = db.Staffs.FirstOrDefault(s => s.Id == id);
            db.Staffs.Remove(staff);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
