using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sheet2_get_post_razor.Controllers
{
    public class LetterGradeController : Controller
    {
        // GET: LetterGrade
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(FormCollection form)
        {
            double exam1Grade = Double.Parse(form["exam1"]);
            double exam2Grade = Double.Parse(form["exam2"]);
            double exam3Grade = Double.Parse(form["exam3"]);

            String color = "red";
            double average = (exam1Grade + exam2Grade + exam3Grade) / 3;
            char letterGrade = 'F';
            if (average >= 90)
            {
                letterGrade = 'A';
                color = "green";
            }
            else if (average >= 80){
                letterGrade = 'B';
                color = "green";
            }
            else if (average >= 70)
            {
                letterGrade = 'C';
                color = "yellow";
            }
            else if (average >= 60)
            {
                letterGrade = 'D';
                color = "red";
            }
            ViewBag.color = color;
            ViewBag.average = average;
            ViewBag.letterGrade = letterGrade;


            return View();
        }
    }
}