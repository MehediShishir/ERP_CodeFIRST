using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HR.Models;
using HR.Filters;

namespace HR.Controllers
{
    [AuthFilter]
    public class EmployeesController : Controller
    {
        private HRContext db = new HRContext();

        // GET: Employees
        public ActionResult Index()
        {
            var employees = db.Employees.Include(e => e.Department).Include(e => e.Designation);
            return View(db.Employees.ToList());
        }

        // GET: Employees/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            ViewBag.DepartmentID = new SelectList(db.Departments, "DepartmentID", "DepartmentName");
            ViewBag.DesignationID = new SelectList(db.Designations, "DesignationID", "Title");
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Employees.Add(employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DepartmentID = new SelectList(db.Departments, "DepartmentID", "DepartmentName", employee.DepartmentID);
            ViewBag.DesignationID = new SelectList(db.Designations, "DesignationID", "Title", employee.DesignationID);

            return View(employee);
        }

        // GET: Employees/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Employee employee = db.Employees.Find(id);
            if (employee == null) return HttpNotFound();

            ViewBag.DepartmentID = new SelectList(
                db.Departments,
                "DepartmentID",
                "DepartmentName",
                employee.DepartmentID
            );

            ViewBag.DesignationID = new SelectList(
                db.Designations,
                "DesignationID",
                "Title",
                employee.DesignationID
            );

            return View(employee);
        }


        // POST: Employees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DepartmentID = new SelectList(db.Departments, "DepartmentID", "DepartmentName", employee.DepartmentID);
            ViewBag.DesignationID = new SelectList(db.Designations, "DesignationID", "Title", employee.DesignationID);

            return View(employee);
        }


        // GET: Employees/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Employee employee = db.Employees.Find(id);
            db.Employees.Remove(employee);
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
