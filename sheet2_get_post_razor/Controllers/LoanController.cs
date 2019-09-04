using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sheet2_get_post_razor.Controllers
{
    public class LoanController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection form)
        {
            double investment = double.Parse(form["investment"]);
            double intRate = (double.Parse(form["intRate"])/100);
            double years = double.Parse(form["years"]);

            double investmentReturn = investment;
            for(int i=0; i<years; i++)
            {
                investmentReturn = investmentReturn + (investmentReturn * intRate);
            }

            ViewBag.years = years;
            ViewBag.investment = investment;
            ViewBag.intRate = intRate*100;


            ViewBag.res = Convert.ToDecimal(investmentReturn).ToString("C");
            return View();
        }
        //[HttpPost]
        //public ActionResult Index()
        //{

        //}
    }
}