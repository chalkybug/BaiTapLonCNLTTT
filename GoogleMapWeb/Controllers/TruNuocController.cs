﻿using GoogleMapWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace GoogleMapWeb.Controllers
{
    public class TruNuocController : Controller
    {
        // GET: TruNuoc
        public string baseAddress = "http://localhost:8177/api/";
        public ActionResult Index()
        {
            List<TruNuoc> item = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                //HTTP GET
                var responseTask = client.GetAsync("trunuoc");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<List<TruNuoc>>();
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
            return View();
        }

        [HttpPost]
        public ActionResult Create(TruNuoc trunuoc)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);

                //HTTP POST
                var postTask = client.PostAsJsonAsync<TruNuoc>("trunuoc", trunuoc);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index", "TruNuoc");
                }
            }

            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

            return RedirectToAction("Index", "TruNuoc");
        }

        public ActionResult Edit(int id)
        {
            List<TruNuoc> item = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                //HTTP GET
                var responseTask = client.GetAsync("trunuoc");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<List<TruNuoc>>();
                    readTask.Wait();

                    item = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..    

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            TruNuoc res = item.Where(x => x.id == id).FirstOrDefault();
            return View(res);
        }

        [HttpPost]
        public ActionResult Edit(TruNuoc trunuoc)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);

                //HTTP POST
                var postTask = client.PutAsJsonAsync<TruNuoc>("trunuoc", trunuoc);

                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index", "TruNuoc");
                }
            }

            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

            return RedirectToAction("Index", "TruNuoc");
        }


        public ActionResult Delete(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);

                //HTTP POST
                var deleteTask = client.DeleteAsync("trunuoc/" + id.ToString());
                deleteTask.Wait();

                var result = deleteTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index", "TruNuoc");
                }
            }

            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

            return RedirectToAction("Index", "TruNuoc");
        }
    }
}