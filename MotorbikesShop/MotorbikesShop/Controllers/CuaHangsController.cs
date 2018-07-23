using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MotorbikesShop.Models;

namespace MotorbikesShop.Controllers
{
    public class CuaHangsController : Controller
    {
        private MotorbikesShopEntities db = new MotorbikesShopEntities();

        // GET: CuaHangs
        public ActionResult CuaHang()
        {
            return View(db.CuaHangs.ToList());
        }

        // GET: CuaHangs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CuaHang cuaHang = db.CuaHangs.Find(id);
            if (cuaHang == null)
            {
                return HttpNotFound();
            }
            return View(cuaHang);
        }

        // GET: CuaHangs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CuaHangs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaCuaHang,TenCuaHang,DiaChi,SoDienThoai")] CuaHang cuaHang)
        {
            if (ModelState.IsValid)
            {
                db.CuaHangs.Add(cuaHang);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cuaHang);
        }

        // GET: CuaHangs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CuaHang cuaHang = db.CuaHangs.Find(id);
            if (cuaHang == null)
            {
                return HttpNotFound();
            }
            return View(cuaHang);
        }

        // POST: CuaHangs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaCuaHang,TenCuaHang,DiaChi,SoDienThoai")] CuaHang cuaHang)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cuaHang).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cuaHang);
        }

        // GET: CuaHangs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CuaHang cuaHang = db.CuaHangs.Find(id);
            if (cuaHang == null)
            {
                return HttpNotFound();
            }
            return View(cuaHang);
        }

        // POST: CuaHangs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CuaHang cuaHang = db.CuaHangs.Find(id);
            db.CuaHangs.Remove(cuaHang);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
