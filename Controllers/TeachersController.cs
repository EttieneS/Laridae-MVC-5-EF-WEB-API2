using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laeridae_API.Controllers;
using Laeridae_API.Models;


namespace Laeridae.Controllers
{
    public class TeachersController : Controller
    {   
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create(Teachers teacher)
        {
            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }

        public ActionResult Details()
        {
            return View();
        }
    }
}