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
        public ViewResult Test(int n)
        {
            int a = 0;
            int b = 1;

            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            
            return View(a);
        }
        [HttpGet]
        public ViewResult AddMaxNumber()
        {
            return View();
        }
        [HttpPost]
        public ViewResult AddMaxNumber(int maxNum)
        {
            return View();
        }
    }
}