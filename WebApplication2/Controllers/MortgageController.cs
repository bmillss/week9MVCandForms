using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class MortgageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult MyPage()
        {
            ViewData["FirstName"] = "Steve";
            ViewData["LastName"] = "Smith";
            return View();
        }
        public IActionResult MyForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ThankYouPage(string firstname, string lastname)
        {
            ViewData["FirstName"] = firstname;
            ViewData["LastName"] = lastname;
            return View();
        }
        public IActionResult MyFormClass()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ThanksAgain(MyNewClass newclass)
        {
            ViewData["MyNewClass"] = newclass;
            return View();
        }
    }
}
