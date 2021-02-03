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
        [Required(ErrorMessage = "L'adresse E-Mail de récupération doit être saisi.")]
        [EmailAddress(ErrorMessage = "Vous devez saisir une adresse E-Mail valide.")]
        public string Email { get; set; }
    }
}
