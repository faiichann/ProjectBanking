using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectBanking.Models;

namespace ProjectBanking.Controllers
{
    public class FormCustomer : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Customer info)
        {
            if (ModelState.IsValid)
            {
                return View("Confirm", info);
            }
            return View("info");
        }
    }
}
