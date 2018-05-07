using GoogleMapWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace GoogleMapWeb.Controllers
{
    public class DamChayController : Controller
    {
        // GET: DamChay
        public string baseAddress = "http://localhost:8177/api/";
        public ActionResult Index()
        {
            List<DamChay> item = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                //HTTP GET
                var responseTask = client.GetAsync("damchay");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<List<DamChay>>();
                    readTask.Wait();

                    item = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..    

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }

            return View(item);
        }
      
        public ActionResult Create()
        {

            return View() ;
        }

        [HttpPost]
        public ActionResult Create(DamChay damchay)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);

                //HTTP POST
                var postTask = client.PostAsJsonAsync<DamChay>("damchay", damchay);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index", "DamChay");
                }
            }

            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

            return RedirectToAction("Index", "DamChay");
        }
        
       // [Route("DamChay/Edit/{id:int}")]
        public ActionResult Edit(int id)
        {
            List<DamChay> item = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                //HTTP GET
                var responseTask = client.GetAsync("damchay");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<List<DamChay>>();
                    readTask.Wait();

                    item = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..    

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            DamChay res = item.Where(x => x.id == id).FirstOrDefault();
            return View(res);
        }

        [HttpPost]
        public ActionResult Edit(DamChay damchay)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);

                //HTTP POST
                var postTask = client.PutAsJsonAsync<DamChay>("damchay", damchay);
               
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index", "DamChay");
                }
            }

            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

            return RedirectToAction("Index", "DamChay");
        }


        public ActionResult Delete(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);

                //HTTP POST
                var deleteTask = client.DeleteAsync("damchay/"+id.ToString());
                deleteTask.Wait();

                var result = deleteTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index", "DamChay");
                }
            }

            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

            return RedirectToAction("Index", "DamChay");
        }
    }
}