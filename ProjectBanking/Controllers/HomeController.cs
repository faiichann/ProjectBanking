﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectBanking.Models;

namespace ProjectBanking.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CalSaving()
        {
            int Firstmoney = Convert.ToInt32(HttpContext.Request.Form["Smoney"].ToString());
            int Rate = Convert.ToInt32(HttpContext.Request.Form["Srate"].ToString());
            int Term = Convert.ToInt32(HttpContext.Request.Form["Sday"].ToString());

            int TotalRate = (Firstmoney*(Rate/100)*Term)/365;
            int Total = Firstmoney+TotalRate;
            ViewBag.Earlysaving = Firstmoney.ToString();
            ViewBag.Ratesaving = TotalRate.ToString();
            ViewBag.Totalsaving = Total.ToString();
            return View("saving");
        }
        public IActionResult CalFixed()
        {
            float Firstmoney = Convert.ToInt32(HttpContext.Request.Form["Fmoney"].ToString());
            float Secondmoney = Convert.ToInt32(HttpContext.Request.Form["Smoney"].ToString());
            float Rate = Convert.ToInt32(HttpContext.Request.Form["Frate"].ToString());
            int Term = Convert.ToInt32(HttpContext.Request.Form["Fday"].ToString());

            if (Term == 3)
            {
                Rate = 2;
                float TotalMoney = Firstmoney + (Secondmoney * 3);
                float TotalRate = ((Firstmoney + (Secondmoney * 3)) * (Rate / 100) * 90) / 365;
                float Total = TotalMoney + TotalRate;
                ViewBag.Earlysaving = Firstmoney.ToString();
                ViewBag.Lastsaving = TotalMoney.ToString();
                ViewBag.Ratesaving = TotalRate.ToString();
                ViewBag.Totalsaving = Total.ToString();
            }
            if (Term == 6)
            {
                Rate = 3;
                float TotalMoney = Firstmoney + (Secondmoney * 6);
                float TotalRate = ((Firstmoney +(Secondmoney * 6)) * (Rate / 100) * 183) / 365;
                float Total = TotalMoney + TotalRate;
                ViewBag.Earlysaving = Firstmoney.ToString();
                ViewBag.Lastsaving = TotalMoney.ToString();
                ViewBag.Ratesaving = TotalRate.ToString();
                ViewBag.Totalsaving = Total.ToString();
            }
        
            if (Term == 12)
            {
                Rate = 4;
                float TotalMoney = Firstmoney + (Secondmoney * 12);
                float TotalRate = ((Firstmoney + (Secondmoney * 12)) * (Rate / 100) * 365) / 365;
                float Total = TotalMoney + TotalRate;
                ViewBag.Earlysaving = Firstmoney.ToString();
                ViewBag.Lastsaving = TotalMoney.ToString();
                ViewBag.Ratesaving = TotalRate.ToString();
                ViewBag.Totalsaving = Total.ToString();
            }
            return View("Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
