using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mylove.Controllers.Api
{
    public class ApiBaseController: ControllerBase
    {
        [Route("help")]
        public string help()
        {
            return "This is Help Page!!!";
        }
    }
}
