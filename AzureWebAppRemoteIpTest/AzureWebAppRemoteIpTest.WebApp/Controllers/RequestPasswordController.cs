using AzureWebAppRemoteIpTest.WebApp.Models;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace AzureWebAppRemoteIpTest.WebApp.Controllers
{
    public class RequestPasswordController : Controller
    {
        public IActionResult Index()
        {
            var connection = HttpContext.Features.Get<IHttpConnectionFeature>();
            IPAddress clientIP = connection.RemoteIpAddress;

            var result = HttpContext.Connection.RemoteIpAddress?.ToString();

            return View(new RequestPasswordViewModel
            {
                Email = "toto@tata.com",
                Ip = result
            });
        }
    }
}
