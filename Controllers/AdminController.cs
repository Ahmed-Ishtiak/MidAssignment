using MidAssignment.EF;
using MidAssignment.EF.Models;
using MidAssignment.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace MidAssignment.Controllers
{
    public class AdminController:Controller
    {
        public ActionResult Index()
        {
            PMSContext db = new PMSContext();
            var admin = db.Restuarents.ToList();
            return View(admin);
        }
        public ActionResult Accept(int id)
        {
            PMSContext db = new PMSContext();
            db.Restuarents.Find(id).Status = "Request Accepted";
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        
        public ActionResult Decline(int id)
        {
            PMSContext db= new PMSContext();
            db.Restuarents.Find(id).Status = "Request Declined";
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Assign_Employee() 
        {
            PMSContext db = new PMSContext();
            var admin = db.Employees.Include("restuarent").ToList();
            return View(admin);
        }
        public ActionResult Create_Employee()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create_Employee(Employee emp)
        {
            if (ModelState.IsValid == true)
            {
                PMSContext db = new PMSContext();
                db.Employees.Add(emp);
                int a = db.SaveChanges();
                if (a > 0)
                {
                    TempData["InsertMessage"] = "Employee has been updated";
                    return RedirectToAction("Employee_List");
                }
                else
                {
                    ViewBag.InsertMessage = "Employee update failed";
                }

            }

            return View();
        }
        public ActionResult Employee_List()
        {
            PMSContext db = new PMSContext();
            var emp = db.Employees.ToList();
            return View(emp);
        }
    }
}