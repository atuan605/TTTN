using MotorbikesShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MotorbikesShop.Controllers
{
    public class DangNhapController : Controller
    {
        MotorbikesShopEntities db = new MotorbikesShopEntities();
        [HttpGet]
        // GET: DangNhap
        public ActionResult DangNhap()
        {
            HttpContext.Session["login"] = "";
            return View();
        }
        [HttpPost]
        public ActionResult DangNhap(string Username, string Password)
        {

            var user = db.KhachHangs.Where(s => s.TaiKhoan == Username && s.MatKhau == Password);
            List<KhachHang> listuser = user.ToList();
            if (listuser.Count == 0)
            {
                ViewBag.ms = ("Tài khoản hoặc mật khẩu không đúng");
                return View();
            }
            else
            {
                Session["login"] = Username;
                return Redirect("http://localhost:50589/SanPhams/Index");
            }
        }
        public ActionResult Thoat()
        {
            System.Diagnostics.Debug.WriteLine("Thoat");
            Session.Clear();
            FormsAuthentication.SignOut();
            return Redirect("http://localhost:50589/SanPhams/Index");
        }
    }
}