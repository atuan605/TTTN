using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MotorbikesShop.Controllers
{
    public class DichVuController : Controller
    {
        // GET: DichVu
        public ActionResult GiaHanBaoHanh()
        {
            return View();
        }
        public ActionResult DieuLeBaoHanh()
        {
            return View();
        }
        public ActionResult ThoiHanBaoHanh()
        {
            return View();
        }
    }
}
