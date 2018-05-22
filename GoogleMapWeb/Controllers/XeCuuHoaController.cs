﻿using GoogleMapWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace GoogleMapWeb.Controllers
{
    public class XeCuuHoaController : Controller
    {
        // GET: XeCuuHoa
        public string baseAddress = "http://localhost:8177/api/";
        List<XeCuuHoa> listXeCuuHoa = null;
        public ActionResult Index()
        {
           

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                //HTTP GET
                var responseTask = client.GetAsync("xecuuhoa");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<List<XeCuuHoa>>();
                    readTask.Wait();

                    listXeCuuHoa = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..    

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }

            return View(listXeCuuHoa);
        }

        public ActionResult Create()
        {
           // ViewBag.DropdownTramCuuHoa = new SelectList(listXeCuuHoa, "id", "name");
            return View();
        }

        [HttpPost]
        public ActionResult Create(XeCuuHoa xecuuhoa)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);

                //HTTP POST
                var postTask = client.PostAsJsonAsync<XeCuuHoa>("xecuuhoa", xecuuhoa);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index", "XeCuuHoa");
                }
            }

            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

            return RedirectToAction("Index", "XeCuuHoa");
        }

        public ActionResult Edit(int id)
        {
            List<XeCuuHoa> item = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                //HTTP GET
                var responseTask = client.GetAsync("xecuuhoa");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<List<XeCuuHoa>>();
                    readTask.Wait();

                    item = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..    

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            XeCuuHoa res = item.Where(x => x.id == id).FirstOrDefault();
            return View(res);
        }

        [HttpPost]
        public ActionResult Edit(XeCuuHoa xecuuhoa)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);

                //HTTP POST
                var postTask = client.PutAsJsonAsync<XeCuuHoa>("xecuuhoa", xecuuhoa);

                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index", "XeCuuHoa");
                }
            }

            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

            return RedirectToAction("Index", "XeCuuHoa");
        }


        public ActionResult Delete(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);

                //HTTP POST
                var deleteTask = client.DeleteAsync("xecuuhoa/" + id.ToString());
                deleteTask.Wait();

                var result = deleteTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index", "XeCuuHoa");
                }
            }

            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

            return RedirectToAction("Index", "XeCuuHoa");
        }
    }
}