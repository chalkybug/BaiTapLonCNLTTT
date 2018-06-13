using MapData.DTO;
using MapWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace MapWeb.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        [CustomAuthentication]
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(FormCollection form)
        {
            List<Account> list = null;

            if (ModelState.IsValid)
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:8177/api/");
                    //HTTP GET
                    var responseTask = client.GetAsync("taikhoan");
                    responseTask.Wait();

                    var result = responseTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var readTask = result.Content.ReadAsAsync<List<Account>>();
                        readTask.Wait();

                        list = readTask.Result;
                    }
                    else //web api sent error response 
                    {
                        //log response status here..
                        
                        ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                    }
                }

                string username = form["username"].ToString();
                string pass = form["password"].ToString();

                foreach (var item in list)
                {
                    if (item.username.Equals(username)
                        && item.password.Equals(pass))
                    {

                        MySession.setAdmin(GroupName.ADMIN_GROUP,item);
                       
                        return View("Index");

                    }
                }

                ModelState.AddModelError("Lỗi đăng nhập", "Bạn không có quyền truy cập");


            }
            return View("Login");

        }

        [AllowAnonymous]
        public ActionResult Notification()
        {
            return View();
        }

    }
}