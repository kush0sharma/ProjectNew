using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BL;

namespace ProjectNew.Controllers
{
    public class HomeController : Controller
    {
        private IEmployee _IEmployee;

        public HomeController(IEmployee iemployee)
        {
            _IEmployee = iemployee;
        }
        // GET: Home
        public ActionResult Index()
        {
            string name = _IEmployee.GetEmployeeName();
            ViewBag.message = name;
            return View();
        }
    }
}