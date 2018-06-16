using MapWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MapWeb.Controllers
{
    public class XeCuuHoaController : Controller
    {
        // GET: XeCuuHoa
        [CustomAuthentication]
        public ActionResult Index()
        {
            return View();
        }
    }
}