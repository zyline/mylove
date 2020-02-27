using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mylove.Models;

namespace mylove.Controllers
{
    //[Route("my/[controller]")]
    [Route("my/")] //指定名称
    [Route("[controller]")]//这个是使用 默认的 controller

    public class testController : Controller
    {
        [Route("a")]
        [Route("b")]
        public IActionResult Index()
        {
            return Content("dddddddddddddd");
        }
        [Route("info")]
        public IActionResult self()
        {
            return View("../Home/Privacy");
        }
        [Route("detail")]
        public IActionResult detail(int id=5)
        {
            DataRow rs = Sky.DbCls.DbHelperLite.QueryRow("select * from diary where id='"+id+"'");
            
            IndexModel index = new IndexModel();
            var info = new
            {
                title = rs["title"].ToString(),
                content = rs["contents"].ToString()
            };
            index.dict.Add("info", rs["title"].ToString());
            index.dict.Add("contents", rs["contents"].ToString());
            return View("../Home/Privacy",index);
        }
    }
}