using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MapWeb.Controllers
{
    public class ThongKeController : Controller
    {
        // GET: ThongKe
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ThongKeTungKhu()
        {
            return View();
        }

        public ActionResult ThongKeTatCaKhu()
        {
            return View();
        }
    }
}