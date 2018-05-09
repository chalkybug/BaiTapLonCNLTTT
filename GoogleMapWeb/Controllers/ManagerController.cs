
using GoogleMapWeb.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace GoogleMapWeb.Controllers
{
    public class ManagerController : Controller
    {
        public string baseAddress = "http://localhost:8177/api/";
        // GET: Manager
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Admin()
        {
            
            return View();
        }
    }
}