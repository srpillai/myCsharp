using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpaDay.Controllers
{
    public class SpaController : Controller
    { 
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("/spa")]
        public IActionResult Menu(string skintype, string manipedi)
        {
            Client newClient = new Client(skintype, manipedi);
            newClient.SetFacials(newClient.SkinType);
            ViewBag.client = newClient;
            return View();
        }
    }
}
