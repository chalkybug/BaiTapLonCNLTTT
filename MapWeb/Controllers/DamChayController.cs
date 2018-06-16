using MapData.DTO;
using MapWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace MapWeb.Controllers
{
    public class DamChayController : Controller
    {
        [CustomAuthentication]
        public ActionResult Index()
        {
          
            return View();
        }
        

    }
}