using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FibMVC.Biz;

namespace FibMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Test()
        {
                        
            return View();
        }
        [HttpGet]
        public ActionResult AddMaxNumber()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddMaxNumber(int maxNum)
        {
            
            return View();
        }
        
    }
}