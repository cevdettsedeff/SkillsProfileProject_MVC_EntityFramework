using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using SkillsProfileProject_MVC_EntityFramework;
using SkillsProfileProject_MVC_EntityFramework.Models.Classes;

namespace SkillsProfileProject_MVC_EntityFramework.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            Context c = new Context();
            var values = c.Skills.ToList();
            return View(values);
        }
    }
}