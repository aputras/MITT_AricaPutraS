using Microsoft.AspNetCore.Mvc;
using MITT.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace MITT.Controllers
{
    public class LoginController : Controller
    {
        MITT.Base.Port getPort = new Base.Port();

        public IActionResult Index()
        {
            return View();
        }

        public JsonResult FE_Authentication(UserVM userVM)
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri(getPort.link)
            };
            var myContent = JsonConvert.SerializeObject(userVM);
            var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var responseTask = client.PostAsync("Logins/", byteContent);
            responseTask.Wait();
            var result = responseTask.Result;
            return Json(result);
        }
    }
}
