using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mylove.Models;
using Sky.Utils;

namespace mylove.Controllers
{
    //[Route("[controller]")]
    //[Route("")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        //[Route("[action]")]
        public IActionResult Index1()
        {
            return Content("dasdfasdfaffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff");
        }
        //[Route("[action]")]
        public IActionResult Index()
        {
            AjaxJson ajx = new AjaxJson();
            ajx.code = 1;
            ajx.msg = "测试一下了！";
            ajx.data.Add("a", "aaaaaaaaaaAAAAAAAAAAAAAAAAA");
            ajx.data.Add("b", "BBBBBBBBBBBBBB");

            DataTable dt = Sky.DbCls.DbHelperLite.QueryTable("select * from diary where 1=1 order by look desc limit 100");
            var directory = System.IO.Directory.GetCurrentDirectory();
            IndexModel index = new IndexModel();
            index.dict.Add("json", ajx.SerializeToJson());
            index.dict.Add("data", dt);

            var data = new {
                a="AAAAAAAAAAAAAAAAAAAAAA",
                b="BBBBBBBBBBBBBBB",
                c="CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC"
            };
            
            index.dict.Add("info", data);
            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic.Add("a", "AAAAAAAAAAAAAAAAAAAAAA");
            dic.Add("b", "BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB");
            index.dict.Add("dict", dic);
            //return Content(directory);
            //return Content(AjaxJson.Obj2Json(dt));
            //return Content(ajx.SerializeToJson());


            return View(index);
        }

        //[Route("[action]")]
        public IActionResult Privacy()
        {
            return View();
        }
        //[Route("[action]")]
        public IActionResult Detail(int id)
        {            
            DataRow rs= Sky.DbCls.DbHelperLite.QueryRow("select * from diary where id='"+id+"'");
            //AjaxJson ajx = new AjaxJson();
            IndexModel index = new IndexModel();
            index.dict.Add("info", AjaxJson.Obj2Json(rs));
            index.dict.Add("data", rs);
            return View(index);
        }

        //[Route("[action]")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
