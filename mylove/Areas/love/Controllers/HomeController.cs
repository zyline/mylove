using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace mylove.Areas.Controllers
{
    [Route("love")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
            //return Content("ddddddddfasdfasdfadsfasdf");
        }
        public IActionResult Tt()
        {
            return View();
            //return Content("dddddddddddddddddddddddddddddddddddddddsssssssssssssssssssssss");
        }
        public IActionResult Json()
        {
            var tempObj = new { Controller = "HomeController", Action = "JsonResultDemo" };
            return Json(tempObj);
        }
        public IActionResult JS()
        {
            return PartialView();
            //return JavaScript(@"<script>alert('Test JavaScriptResultDemo!')</script>");
        }
    }
}