using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AzureWebAppRemoteIpTest.WebApp.Models
{
    public class RequestPasswordViewModel
    {
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "IP Address")]
        public string Ip { get; set; }
    }
}
