using MotorbikesShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MotorbikesShop.Controllers
{
    public class DangKyController : Controller
    {
        // GET: DangKy
        [HttpGet]
        public ActionResult DangKy()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DangKy(KhachHang kh)
        {
            if (ModelState.IsValid)
            {
                using (MotorbikesShopEntities db = new MotorbikesShopEntities())
                {
                    db.KhachHangs.Add(kh);
                    db.SaveChanges();
                    ModelState.Clear();
                    kh = null;
                    ViewBag.Success = "Đăng ký thành công";
                    return Redirect("DangNhap");
                }
            }
            return View(kh);
        }
    }
}
