
using BENET.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BENET.Controllers
{
    public class SportController : Controller
    {
        private ApplicationDbContext context;

        public SportController()
        {
            context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            context.Dispose();
        }

        // GET: Sport
        public ActionResult Index()
        {
            List<SportModel> sports = context.Sports.ToList();
            return View("Index", sports);
        }
        public ActionResult Details(int id)
        {
            SportModel sport = context.Sports.SingleOrDefault( g => g.Id == id);


            return View("Details", sport);
        }
        [Authorize]
        public ActionResult Create()
        {
            return View("SportForm", new SportModel());
        }
        [Authorize]
        public ActionResult Edit(int id)
        {
            SportModel sport = context.Sports.SingleOrDefault(g => g.Id == id);


            return View("SportForm", sport);
        }
        [Authorize]
        public ActionResult Delete(int id)
        {
            SportModel sport = context.Sports.SingleOrDefault(g => g.Id == id);
            context.Entry(sport).State = EntityState.Deleted;
            context.SaveChanges();

            return Redirect("/Sport");
        }
        [Authorize]
        public ActionResult ProccessCreate(SportModel sportModel)
        {
            //Save to DB
            SportModel sport = context.Sports.SingleOrDefault(g => g.Id == sportModel.Id);

            //edit
            if (sport != null)
            {
                sport.SportName = sportModel.SportName;
                sport.SportType = sportModel.SportType;
                sport.SportDrill = sportModel.SportDrill;

                context.SaveChanges();
            }
            else
            {
                context.Sports.Add(sportModel);
            }
            context.SaveChanges();


            return View("Details", sportModel);
        }

        public ActionResult SearchForm()
        {
            return View("SearchForm");
        }

        public ActionResult SearchForName(string searchPhrase)
        {
            //Get List of Search
            var sports = from g in context.Sports
                         where g.SportName.Contains(searchPhrase)
                         select g;

            return View("Index", sports);
        }

        public ActionResult SearchForType(string searchPhrase)
        {
            //Get List of Search
            var sports = from g in context.Sports
                         where g.SportType.Contains(searchPhrase)
                         select g;

            return View("Index", sports);
        }
    }
    
}