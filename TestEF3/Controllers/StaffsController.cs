﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TestEF3.Models;

namespace TestEF3.Controllers
{
    public class StaffsController : Controller
    {
        private MyDB db = new MyDB();

        // GET: Staffs
        public ActionResult Index()
        {
            var staff = db.staff.Include(s => s.Address).Include(s => s.Gender);
            return View(staff.ToList());
        }

        // GET: Staffs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Staff staff = db.staff.Find(id);
            if (staff == null)
            {
                return HttpNotFound();
            }
            return View(staff);
        }

        // GET: Staffs/Create
        public ActionResult Create()
        {
            ViewBag.AddressId = new SelectList(db.address, "AddressId", "AddressName");
            ViewBag.GenderId = new SelectList(db.gender, "GenderId", "GenderName");
            return View();
        }

        // POST: Staffs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StaffId,StaffName,AddressId,GenderId,StaffPhone,StaffSalary")] Staff staff)
        {
            if (ModelState.IsValid)
            {
                db.staff.Add(staff);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AddressId = new SelectList(db.address, "AddressId", "AddressName", staff.AddressId);
            ViewBag.GenderId = new SelectList(db.gender, "GenderId", "GenderName", staff.GenderId);
            return View(staff);
        }

        // GET: Staffs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Staff staff = db.staff.Find(id);
            if (staff == null)
            {
                return HttpNotFound();
            }
            ViewBag.AddressId = new SelectList(db.address, "AddressId", "AddressName", staff.AddressId);
            ViewBag.GenderId = new SelectList(db.gender, "GenderId", "GenderName", staff.GenderId);
            return View(staff);
        }

        // POST: Staffs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StaffId,StaffName,AddressId,GenderId,StaffPhone,StaffSalary")] Staff staff)
        {
            if (ModelState.IsValid)
            {
                db.Entry(staff).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AddressId = new SelectList(db.address, "AddressId", "AddressName", staff.AddressId);
            ViewBag.GenderId = new SelectList(db.gender, "GenderId", "GenderName", staff.GenderId);
            return View(staff);
        }

        // GET: Staffs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Staff staff = db.staff.Find(id);
            if (staff == null)
            {
                return HttpNotFound();
            }
            return View(staff);
        }

        // POST: Staffs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Staff staff = db.staff.Find(id);
            db.staff.Remove(staff);
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
