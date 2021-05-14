using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laeridae_API.Models;

namespace Laeridae.Controllers
{
    public class StudentsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create(Students student)
        {
            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }
    }
}