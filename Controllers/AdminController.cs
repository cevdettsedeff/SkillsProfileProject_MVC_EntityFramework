using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SkillsProfileProject_MVC_EntityFramework.Models.Classes;


namespace SkillsProfileProject_MVC_EntityFramework.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin

        Context contextt = new Context();
        public ActionResult Index()
        {
            

            var values = contextt.Skills.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult NewSkill()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewSkill(Skills y)
        {
            contextt.Skills.Add(y);
            contextt.SaveChanges();
            return View();

        }

        public ActionResult DeleteSkill(int id)
        {
            var value = contextt.Skills.Find(id);
            contextt.Skills.Remove(value);
            contextt.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateSkill(int id)
        {
            var value = contextt.Skills.Find(id);
            return View("UpdateSkill", value);
        }

        [HttpPost]
        public ActionResult UpdateSkill(Skills y)
        {
            var x = contextt.Skills.Find(y.Id);
            x.Information = y.Information;
            x.Value = y.Value;
            contextt.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}