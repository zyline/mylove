using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace mylove.Controllers.Api
{
    [Route("api/mt")]
    //[ApiController]
    public class activeController : ApiBaseController
    {
        public string index()
        {
            return "Api Index Page!!!!!";
        }
        [Route("sendcode")]
        public string test()
        {
            return "你好，我是测试！";
        }
        [Route("ttt")]
        public IActionResult myt()
        {
            return Content("ddddddddddddddddddd");
        }
    }
}