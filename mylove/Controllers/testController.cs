using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace mylove.Controllers
{
    //[Route("my/[controller]")]
    [Route("my/")]
    public class testController : Controller
    {
        [Route("a")]
        [Route("b")]
        public IActionResult Index()
        {
            return Content("dddddddddddddd");
        }
    }
}