using Implement_Swagger_UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Implement_Swagger_UI.Controllers
{
    [Route("api/HomeController")]
    public class HomeController : Controller
    {
        [Route("Test_Swagger")]
        [HttpGet]
        public async Task<string> TestSwagger()
        {
            return "This is Just an Demo";
        }
    }
}
