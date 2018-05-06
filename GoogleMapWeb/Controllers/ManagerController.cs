using GoogleMapWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace GoogleMapWeb.Controllers
{
    public class ManagerController : Controller
    {
        // GET: Manager
        public ActionResult Index()
        {
            List<DamChay> students = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:8177/api/");
                //HTTP GET
                var responseTask = client.GetAsync("Manager");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<List<DamChay>>();
                    readTask.Wait();

                    students = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                  ///  students = Enumerable.Empty<DamChay>();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }

            return View(students);
        }
    }
}