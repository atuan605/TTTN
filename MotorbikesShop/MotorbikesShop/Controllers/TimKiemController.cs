using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MotorbikesShop.Models;
using PagedList;
using PagedList.Mvc;

namespace MotorbikesShop.Controllers
{
    public class TimKiemController : Controller
    {
        MotorbikesShopEntities db = new MotorbikesShopEntities();
        [HttpGet]
        public ActionResult KetQuaTimKiem()
        {
            return View();
        }
        [HttpPost]
        // GET: TimKiem
        public ActionResult KetQuaTimKiem(FormCollection f)
        {
            string sTuKhoa = f ["search"].ToString();
            List<SanPham> lstKQTK = db.SanPhams.Where(n => n.TenSP.Contains(sTuKhoa)).ToList();
            if (lstKQTK.Count == 0)
            {
                ViewBag.ThongBao = "Không tìm thấy sản phẩm nào";
                return View("DangNhap");
            }
            else
            {
                ViewBag.ThongBao = "Đã tìm thấy" + lstKQTK.Count + "Kết quả!";
                return View(lstKQTK.OrderBy(n => n.TenSP));
            }
        }
        public ActionResult KhongSP()
        {
            return View();
        }
    }
}