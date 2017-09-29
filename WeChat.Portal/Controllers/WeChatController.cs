using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WeChat.Portal.Controllers
{
    [Produces("application/json")]
    [Route("api/WeChat")]
    public class WeChatController : Controller
    {
        public IActionResult Get()
        {
            return Content("OK");
        }

    }
}