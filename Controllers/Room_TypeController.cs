using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Hotel_MS.DBContext;
using Hotel_MS.Models;

namespace Hotel_MS.Controllers
{
    public class Room_TypeController : Controller
    {
        private AppDBContext db = new AppDBContext();

        // GET: Room_Type
        public ActionResult Index()
        {
            return View(db.Room_Types.ToList());
        }

        // GET: Room_Type/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Room_Type room_Type = db.Room_Types.Find(id);
            if (room_Type == null)
            {
                return HttpNotFound();
            }
            return View(room_Type);
        }

        // GET: Room_Type/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Room_Type/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Capacity,Price,Max_Guest")] Room_Type room_Type)
        {
            if (ModelState.IsValid)
            {
                db.Room_Types.Add(room_Type);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(room_Type);
        }

        // GET: Room_Type/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Room_Type room_Type = db.Room_Types.Find(id);
            if (room_Type == null)
            {
                return HttpNotFound();
            }
            return View(room_Type);
        }

        // POST: Room_Type/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Capacity,Price,Max_Guest")] Room_Type room_Type)
        {
            if (ModelState.IsValid)
            {
                db.Entry(room_Type).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(room_Type);
        }

        // GET: Room_Type/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Room_Type room_Type = db.Room_Types.Find(id);
            if (room_Type == null)
            {
                return HttpNotFound();
            }
            return View(room_Type);
        }

        // POST: Room_Type/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Room_Type room_Type = db.Room_Types.Find(id);
            db.Room_Types.Remove(room_Type);
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
