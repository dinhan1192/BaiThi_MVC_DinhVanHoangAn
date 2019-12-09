using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BaiThi_MVC_DinhVanHoangAn.Models;
using BaiThi_MVC_DinhVanHoangAn.Util;

namespace BaiThi_MVC_DinhVanHoangAn.Controllers
{
    public class ExamsController : Controller
    {
        private BaiThi_MVC_DinhVanHoangAnContext db = new BaiThi_MVC_DinhVanHoangAnContext();

        // GET: Exams
        public ActionResult Index()
        {
            var list = db.Exams.ToList();
            foreach(var item in list)
            {
                var itemSub = DropDownListUtil.GetSubs().Where(s => s.Id == item.ExamSubject).FirstOrDefault();
                if(itemSub != null)
                {
                    item.ExamSubjectName = itemSub.Name;
                }

                var itemClass = DropDownListUtil.GetClasses().Where(s => s.Id == item.ClassRoom).FirstOrDefault();
                if (itemClass != null)
                {
                    item.ClassRoomName = itemClass.Name;
                }

                var itemFaculty = DropDownListUtil.GetFaculties().Where(s => s.Id == item.Faculty).FirstOrDefault();
                if (itemFaculty != null)
                {
                    item.FacultyName = itemFaculty.Name;
                }
            }
            return View(list);
        }

        // GET: Exams/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Exam exam = db.Exams.Find(id);
            if (exam == null)
            {
                return HttpNotFound();
            }
            return View(exam);
        }

        // GET: Exams/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Exams/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ExamSubject,StartTime,ExamDate,ExamDuration,ClassRoom,Faculty,Status")] Exam exam)
        {
            if (ModelState.IsValid)
            {
                db.Exams.Add(exam);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(exam);
        }

        // GET: Exams/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Exam exam = db.Exams.Find(id);
            if (exam == null)
            {
                return HttpNotFound();
            }
            return View(exam);
        }

        // POST: Exams/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ExamSubject,StartTime,ExamDate,ExamDuration,ClassRoom,Faculty,Status")] Exam exam)
        {
            if (ModelState.IsValid)
            {
                db.Entry(exam).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(exam);
        }

        // GET: Exams/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Exam exam = db.Exams.Find(id);
            if (exam == null)
            {
                return HttpNotFound();
            }
            return View(exam);
        }

        // POST: Exams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Exam exam = db.Exams.Find(id);
            db.Exams.Remove(exam);
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
