using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdditionOfNumbers.Models;
using AdditionOfNumbers.HeplerClasses;

namespace AdditionOfNumbers.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(SumModel sum)
        {
            return View(sum);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }


        /// <summary>
        /// Add two integer numbers
        /// </summary>
        /// <param name="sum"></param>
        /// <returns></returns>
        public ActionResult Add(SumModel sum)
        {
            try
            {
                int FirstNumber = sum.FirstNumber;
                int SecondNumber = sum.SecondNumber;
                sum.Result = FirstNumber + SecondNumber;
            }
            catch (Exception ex)
            {
                ViewBag.Message = "Error Occured";
                HandleError.WriteError(ex);
                throw;
            }
            return RedirectToAction("Index", sum);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}