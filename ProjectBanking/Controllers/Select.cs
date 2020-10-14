using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectBanking.Models;

namespace ProjectBanking.Controllers
{
    public class Select : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult index(Customer info)
        {
            if (ModelState.IsValid)
            {
                return View("Complete", info);
            }
            return View("info");
        }
    }
}
