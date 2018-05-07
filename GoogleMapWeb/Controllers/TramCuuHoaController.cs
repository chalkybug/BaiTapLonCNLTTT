using GoogleMapWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace GoogleMapWeb.Controllers
{
    public class TramCuuHoaController : Controller
    {
        // GET: TramCuuHoa
        public string baseAddress = "http://localhost:8177/api/";
        public ActionResult Index()
        {
            List<TramCuuHoa> item = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                //HTTP GET
                var responseTask = client.GetAsync("tramcuuhoa");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<List<TramCuuHoa>>();
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
        public ActionResult Create(TramCuuHoa tramcuuhoa)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);

                //HTTP POST
                var postTask = client.PostAsJsonAsync<TramCuuHoa>("tramcuuhoa", tramcuuhoa);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index", "TramCuuHoa");
                }
            }

            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

            return RedirectToAction("Index", "TramCuuHoa");
        }

        public ActionResult Edit(int id)
        {
            List<TramCuuHoa> item = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                //HTTP GET
                var responseTask = client.GetAsync("tramcuuhoa");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<List<TramCuuHoa>>();
                    readTask.Wait();

                    item = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..    

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            TramCuuHoa res = item.Where(x => x.id == id).FirstOrDefault();
            return View(res);
        }

        [HttpPost]
        public ActionResult Edit(TramCuuHoa tramcuuhoa)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);

                //HTTP POST
                var postTask = client.PutAsJsonAsync<TramCuuHoa>("tramcuuhoa", tramcuuhoa);

                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index", "TramCuuHoa");
                }
            }

            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

            return RedirectToAction("Index", "TramCuuHoa");
        }


        public ActionResult Delete(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);

                //HTTP POST
                var deleteTask = client.DeleteAsync("tramcuuhoa/" + id.ToString());
                deleteTask.Wait();

                var result = deleteTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index", "TramCuuHoa");
                }
            }

            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

            return RedirectToAction("Index", "TramCuuHoa");
        }
    }
}