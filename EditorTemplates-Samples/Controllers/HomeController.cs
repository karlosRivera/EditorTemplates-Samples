using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EditorTemplateSample.Models;

namespace EditorTemplateSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            StudentListViewModel osvm = new StudentListViewModel();
            osvm.Sex = osvm.GetSex();
            osvm.Countries = osvm.GetCountries();
            return View(osvm);
        }

        [HttpPost]
        public ActionResult Index(StudentListViewModel oStudentListViewModel)
        {
            oStudentListViewModel.Sex = oStudentListViewModel.GetSex();
            oStudentListViewModel.Countries = oStudentListViewModel.GetCountries();

            return View(oStudentListViewModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}