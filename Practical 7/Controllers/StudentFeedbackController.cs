using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practical_7.Models;

namespace Practical_7.Controllers
{
    public class StudentFeedbackController : Controller
    {
        static List<Feedback> feedback = new List<Feedback>();

        // GET: StudentFeedback
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Feedback f)
        {
            feedback.Add(f);
            return RedirectToAction("List");
        }

        public ActionResult List()
        {
            return View(feedback);
        }
    }
}