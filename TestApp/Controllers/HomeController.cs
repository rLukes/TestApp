using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Products()
        {
            return View("OurCompanyProducts");
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult GetEmpName(int EmpId)
        {
            var emp = new[]
            {
                new {EmpId=1, EmpNmae="TS", Sallary
                ="500"},
                new {EmpId=2, EmpNmae="Ps", Sallary ="500"}
            };
            string name = emp.FirstOrDefault(e => e.EmpId == EmpId).EmpNmae;
            
            return Content(name, "text/plain");
        }
    }
}