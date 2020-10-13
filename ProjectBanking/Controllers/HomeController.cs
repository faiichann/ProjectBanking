using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectBanking.Models;
using System.Configuration;
using System.Data.SqlClient;
using Microsoft.VisualBasic;
using System.Net;
using System.Data.Entity;
using System.Web;

namespace ProjectBanking.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MyDB db = new MyDB();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.listbank = AllBank();
            return View();
        }
        public ActionResult Fixed()
        {
            FixedDeposit fixedDeposit = new FixedDeposit();
            ViewBag.listbank = AllBank();
            return View();
        }

        public ActionResult Save() 
        {
            Savings savings = new Savings();
            ViewBag.listbank = AllBank();
            return View();
        }
        

        [HttpPost]
        [ValidateAntiForgeryToken]
        public List<Bank> AllBank()
        {
            List<Bank> listbank = new List<Bank>();
            listbank.Add(new Bank { BankID = "001", BankName = "SCB", BankAddress = "Bankok" , BankInterestRate = 0.375});
            listbank.Add(new Bank { BankID = "002", BankName = "Krungsri", BankAddress = "Bankok", BankInterestRate = 1.1 });
            listbank.Add(new Bank { BankID = "003", BankName = "KBank", BankAddress = "Bankok", BankInterestRate = 0.865 });

            ViewBag.orderRate = listbank.OrderByDescending(r => r.BankInterestRate);

            return listbank;
        }
        public List<Savings> AllSave()
        {
            List<Savings> listsave = new List<Savings>();
            listsave.Add(new Savings { SBankName = "SCB", SInterestRate = 0.375, SRate = 23, STerm = 12, SEarlyDeposit = 10000, STotal = 10023 });
            listsave.Add(new Savings { SBankName = "Krungsri", SInterestRate = 1.1, SRate = 50, STerm = 12, SEarlyDeposit = 10000, STotal = 10050 });
            listsave.Add(new Savings { SBankName = "KBank", SInterestRate = 0.865, SRate = 33, STerm = 12, SEarlyDeposit = 10000, STotal = 10033});

            ViewBag.SaveRank = listsave.OrderByDescending(r => r.SInterestRate);

            return listsave;
        }
        public IActionResult CalSaving(Savings savings)
            {
                savings.SEarlyDeposit = Convert.ToDouble(HttpContext.Request.Form["Smoney"].ToString());
                savings.STerm = Convert.ToDouble(HttpContext.Request.Form["Sday"].ToString());
                ViewBag.Sterm = savings.STerm;

            //SCB
            savings.SInterestRate = 0.375;
            double TotalRates1 = (savings.SEarlyDeposit * (savings.SInterestRate / 100) * (savings.STerm * 30.5)) / 365;
            double Totals1 = savings.SEarlyDeposit + TotalRates1;

            ViewBag.Earlysavingb1 = savings.SEarlyDeposit.ToString("0.00");
            ViewBag.Ratesavingb1 = TotalRates1.ToString("0.00");
            ViewBag.Totalsavingb1 = Totals1.ToString("0.00");

            //Krungsri
            savings.SInterestRate = 1.1;
            double TotalRates2 = (savings.SEarlyDeposit * (savings.SInterestRate / 100) * (savings.STerm * 30.5)) / 365;
            double Totals2 = savings.SEarlyDeposit + TotalRates2;

            ViewBag.Earlysavingb2 = savings.SEarlyDeposit.ToString("0.00");
            ViewBag.Ratesavingb2 = TotalRates2.ToString("0.00");
            ViewBag.Totalsavingb2 = Totals2.ToString("0.00");

            //KBANK
            savings.SInterestRate = 0.865;
            double TotalRates3 = (savings.SEarlyDeposit * (savings.SInterestRate / 100) * (savings.STerm * 30.5)) / 365;
            double Totals3 = savings.SEarlyDeposit + TotalRates3;

            ViewBag.Earlysavingb3 = savings.SEarlyDeposit.ToString("0.00");
            ViewBag.Ratesavingb3 = TotalRates3.ToString("0.00");
            ViewBag.Totalsavingb3 = Totals3.ToString("0.00");

            return View("Save",savings);
            }

        public IActionResult CalFixed(FixedDeposit fixedDeposit)
        {
            fixedDeposit.FEarlyDeposit = Convert.ToDouble(HttpContext.Request.Form["Fmoney"].ToString());
            fixedDeposit.FInterestRate = Convert.ToDouble(HttpContext.Request.Form["Frate"].ToString());
            fixedDeposit.FTermperMonth = Convert.ToDouble(HttpContext.Request.Form["Fday"].ToString());

            if (fixedDeposit.FTermperMonth == 3)
            {
                //SCB
                fixedDeposit.FInterestRate = 0.375;
                double TotalRateb1 = (fixedDeposit.FEarlyDeposit * (fixedDeposit.FInterestRate / 100) * 90) / 365;
                double Totalb1 = fixedDeposit.FEarlyDeposit + TotalRateb1;
                ViewBag.Earlyfixsavingb1 = fixedDeposit.FEarlyDeposit.ToString("0.00");
                ViewBag.Ratesfixavingb1 = TotalRateb1.ToString("0.00");
                ViewBag.Totalfixsavingb1 = Totalb1.ToString("0.00");

                //KBANK 
                fixedDeposit.FInterestRate = 0.87;
                double TotalRateb2 = (fixedDeposit.FEarlyDeposit * (fixedDeposit.FInterestRate / 100) * 90) / 365;
                double Totalb2 = fixedDeposit.FEarlyDeposit + TotalRateb2;
                ViewBag.Earlyfixsavingb2 = fixedDeposit.FEarlyDeposit.ToString("0.00");
                ViewBag.Ratesfixavingb2 = TotalRateb2.ToString("0.00");
                ViewBag.Totalfixsavingb2 = Totalb2.ToString("0.00");

                //Krungsri
                fixedDeposit.FInterestRate = 1.1;
                double TotalRateb3 = (fixedDeposit.FEarlyDeposit * (fixedDeposit.FInterestRate / 100) * 90) / 365;
                double Totalb3 = fixedDeposit.FEarlyDeposit + TotalRateb3;
                ViewBag.Earlyfixsavingb3 = fixedDeposit.FEarlyDeposit.ToString("0.00");
                ViewBag.Ratesfixavingb3 = TotalRateb3.ToString("0.00");
                ViewBag.Totalfixsavingb3 = Totalb3.ToString("0.00");

            }
            if (fixedDeposit.FTermperMonth == 6)
            {
                //SCB
                fixedDeposit.FInterestRate = 0.375;
                double TotalRateb1 = (fixedDeposit.FEarlyDeposit * (fixedDeposit.FInterestRate / 100) * 183) / 365;
                double Totalb1 = fixedDeposit.FEarlyDeposit + TotalRateb1;
                ViewBag.Earlyfixsavingb1 = fixedDeposit.FEarlyDeposit.ToString("0.00");
                ViewBag.Ratesfixavingb1 = TotalRateb1.ToString("0.00");
                ViewBag.Totalfixsavingb1 = Totalb1.ToString("0.00");

                //KBANK 
                fixedDeposit.FInterestRate = 0.87;
                double TotalRateb2 = (fixedDeposit.FEarlyDeposit * (fixedDeposit.FInterestRate / 100) * 183) / 365;
                double Totalb2 = fixedDeposit.FEarlyDeposit + TotalRateb2;
                ViewBag.Earlyfixsavingb2 = fixedDeposit.FEarlyDeposit.ToString("0.00");
                ViewBag.Ratesfixavingb2 = TotalRateb2.ToString("0.00");
                ViewBag.Totalfixsavingb2 = Totalb2.ToString("0.00");

                //Krungsri
                fixedDeposit.FInterestRate = 1.1;
                double TotalRateb3 = (fixedDeposit.FEarlyDeposit * (fixedDeposit.FInterestRate / 100) * 183) / 365;
                double Totalb3 = fixedDeposit.FEarlyDeposit + TotalRateb3;
                ViewBag.Earlyfixsavingb3 = fixedDeposit.FEarlyDeposit.ToString("0.00");
                ViewBag.Ratesfixavingb3 = TotalRateb3.ToString("0.00");
                ViewBag.Totalfixsavingb3 = Totalb3.ToString("0.00");
            }
            if (fixedDeposit.FTermperMonth == 12)
            {
                //SCB
                fixedDeposit.FInterestRate = 0.375;
                double TotalRateb1 = (fixedDeposit.FEarlyDeposit * (fixedDeposit.FInterestRate / 100) * 365) / 365;
                double Totalb1 = fixedDeposit.FEarlyDeposit + TotalRateb1;
                ViewBag.Earlyfixsavingb1 = fixedDeposit.FEarlyDeposit.ToString("0.00");
                ViewBag.Ratesfixavingb1 = TotalRateb1.ToString("0.00");
                ViewBag.Totalfixsavingb1 = Totalb1.ToString("0.00");

                //KBANK 
                fixedDeposit.FInterestRate = 0.87;
                double TotalRateb2 = (fixedDeposit.FEarlyDeposit * (fixedDeposit.FInterestRate / 100) * 365) / 365;
                double Totalb2 = fixedDeposit.FEarlyDeposit + TotalRateb2;
                ViewBag.Earlyfixsavingb2 = fixedDeposit.FEarlyDeposit.ToString("0.00");
                ViewBag.Ratesfixavingb2 = TotalRateb2.ToString("0.00");
                ViewBag.Totalfixsavingb2 = Totalb2.ToString("0.00");

                //Krungsri
                fixedDeposit.FInterestRate = 1.1;
                double TotalRateb3 = (fixedDeposit.FEarlyDeposit * (fixedDeposit.FInterestRate / 100) * 365) / 365;
                double Totalb3 = fixedDeposit.FEarlyDeposit + TotalRateb3;
                ViewBag.Earlyfixsavingb3 = fixedDeposit.FEarlyDeposit.ToString("0.00");
                ViewBag.Ratesfixavingb3 = TotalRateb3.ToString("0.00");
                ViewBag.Totalfixsavingb3 = Totalb3.ToString("0.00");
            }
            return View("Fixed",fixedDeposit);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
