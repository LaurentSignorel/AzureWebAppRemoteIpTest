using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureWebAppRemoteIpTest.WebApp.Controllers
{
    public class RequestPasswordController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
