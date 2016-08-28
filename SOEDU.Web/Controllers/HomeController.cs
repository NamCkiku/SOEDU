using Newtonsoft.Json;
using SOEDU.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;

namespace SOEDU.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //using (var client = new HttpClient())
            //{
            //    string url = "http://localhost:2146";
            //    client.BaseAddress = new Uri("http://localhost:2146");
            //    client.DefaultRequestHeaders.Accept.Clear();
            //    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //    HttpResponseMessage response = client.GetAsync(url + "/api/getall").Result;
            //    if (response.IsSuccessStatusCode)
            //    {
            //        string responseString = response.Content.ReadAsStringAsync().Result;
            //        var course = JsonConvert.DeserializeObject<List<ListCourseModel>>(responseString);
            //        return View(course);
            //    }
            //}
            return View();
        }
    }
}