using MidAssignment.EF;
using MidAssignment.EF.Models;
using MidAssignment.Migrations;
using MidAssignment.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace MidAssignment.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            PMSContext db = new PMSContext();
            var restuarents = db.Restuarents.ToList();
            return View(convert(restuarents));
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Restuarent req)
        {
            if (ModelState.IsValid == true)
            {
                PMSContext db = new PMSContext();
                req.Status = "Request in Process";
                db.Restuarents.Add(req);
                int a = db.SaveChanges();
                if (a > 0)
                {
                    TempData["InsertMessage"] = "Request has been updated";
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.InsertMessage = "Resquest update failed";
                }

            }

            return View();
        }
        /*
        public ActionResult Delete(int id)
        {
            PMSContext db = new PMSContext();
            var requestRow = db.Restuarents.Where(model => model.Id == id);
            return View();
        }
        
        [HttpPost]
        public ActionResult Delete(Restuarent req)
        {
            PMSContext db = new PMSContext();
            db.Entry(req).State = EntityState.Deleted;
            int a = db.SaveChanges();
            if(a>0)
            {
                TempData["DeleteMessage"] = "<script>alert('Row has been deleted')</script>";
            }
            else
            {
                TempData["DeleteMessage"] = "<script>alert('Row was not deleted')</script>";
            }    
            return RedirectToAction("Index");
        }
        */
        RestuarentDTO convert(Restuarent res)
        {
            var r = new RestuarentDTO();
            r.Id = res.Id;
            r.Name = res.Name;
            r.Description = res.Description;
            r.MaxTime = res.MaxTime;
            r.Status = res.Status;
            return r;
        }
        Restuarent convert(RestuarentDTO res)
        {
            var r = new Restuarent();
            r.Id = res.Id;
            r.Name = res.Name;
            r.Description = res.Description;
            r.MaxTime = res.MaxTime;
            r.Status= res.Status;
            return r;
        }
        List<RestuarentDTO>convert(List<Restuarent>req)
        {
            var restuarents = new List<RestuarentDTO>();
            foreach(var item in req)
            {
                restuarents.Add(convert(item)); 
            }
            return restuarents;
        }      
    }
}