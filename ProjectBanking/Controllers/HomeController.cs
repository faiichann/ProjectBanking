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
            ViewBag.listbank = AllBank();
            return View();
        }

        [HttpPost]
        public List<Bank> AllBank()
        {
            List<Bank> listbank = new List<Bank>();
            listbank.Add(new Bank { BankID = "001", BankName = "Bank1", BankAddress = "Bankok" , BankInterestRate = 1.1});
            listbank.Add(new Bank { BankID = "002", BankName = "Bank2", BankAddress = "Bankok", BankInterestRate = 2 });
            listbank.Add(new Bank { BankID = "003", BankName = "Bank3", BankAddress = "Bankok", BankInterestRate = 0.8 });

            ViewBag.orderRate = listbank.OrderByDescending(r => r.BankInterestRate);

            return listbank;
        }
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
            int Firstmoney = Convert.ToInt32(HttpContext.Request.Form["Fmoney"].ToString());
            int Rate = Convert.ToInt32(HttpContext.Request.Form["Frate"].ToString());
            int Term = Convert.ToInt32(HttpContext.Request.Form["Fday"].ToString());

            if (Term == 3)
            {
                int TotalRate = (Firstmoney * (Rate / 100) * 90) / 365;
                int Total = Firstmoney + TotalRate;
                ViewBag.Earlysaving = Firstmoney.ToString();
                ViewBag.Ratesaving = TotalRate.ToString();
                ViewBag.Totalsaving = Total.ToString();
            }
            if (Term == 6)
            {
                int TotalRate = (Firstmoney * (Rate / 100) * 183) / 365;
                int Total = Firstmoney + TotalRate;
                ViewBag.Earlysaving = Firstmoney.ToString();
                ViewBag.Ratesaving = TotalRate.ToString();
                ViewBag.Totalsaving = Total.ToString();
            }
            if (Term == 12)
            {
                int TotalRate = (Firstmoney * (Rate / 100) * 365) / 365;
                int Total = Firstmoney + TotalRate;
                ViewBag.Earlysaving = Firstmoney.ToString();
                ViewBag.Ratesaving = TotalRate.ToString();
                ViewBag.Totalsaving = Total.ToString();
            }
            return View("fixeddeposit");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
