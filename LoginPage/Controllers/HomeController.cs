using LoginPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace LoginPage.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult User()
        {
            ViewBag.area = "Hii";
            ViewData["area"] = "Welcome";
            TempData["area"] = "Have a nice day";
            
            return View();
        }
        public ActionResult Correct(Sample set)
        {
            if (set.Name == "Vimala" && set.Password == 12345)
            {
                ViewBag.name = "Success";
                ViewData["Data"] = "Done";
                TempData["value"] = "Welcome";
                return View();
            }
            else
            {
                ViewBag.name = "Sorry";
                ViewData["data"] = "Error";
                TempData["value"] = "Please Check the name and password";
                return View();
            }
        }

               
 
    }
}