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

            return View();
        }


        [HttpGet]
        public ActionResult Save() 
        {
            Savings savings = new Savings();
            ViewBag.listbank = AllBank();
            return View(db.Saving);
        }
        

        [HttpPost]
        [ValidateAntiForgeryToken]
        public List<Bank> AllBank()
        {
            List<Bank> listbank = new List<Bank>();
            listbank.Add(new Bank { BankID = "001", BankName = "Bank1", BankAddress = "Bankok" , BankInterestRate = 1.1});
            listbank.Add(new Bank { BankID = "002", BankName = "Bank2", BankAddress = "Bankok", BankInterestRate = 2 });
            listbank.Add(new Bank { BankID = "003", BankName = "Bank3", BankAddress = "Bankok", BankInterestRate = 0.8 });

            ViewBag.orderRate = listbank.OrderByDescending(r => r.BankInterestRate);

            return listbank;
        }
            public async Task<ActionResult> CalSaving(Savings savings)
            {
                if (ModelState.IsValid)
                {
                    db.Saving.Add(savings);
                    await db.SaveChangesAsync();
                    return RedirectToAction("Save");
                }

                savings.SEarlyDeposit = Convert.ToDouble(HttpContext.Request.Form["Smoney"].ToString());
                savings.SInterestRate = Convert.ToDouble(HttpContext.Request.Form["Srate"].ToString());
                savings.STerm = Convert.ToDouble(HttpContext.Request.Form["Sday"].ToString());

                double[] rank = ViewBag.orderRate;

                double[] Rate = { 1.1, 2, 0.8 };


                if (rank != null)
                {
                    for (int i = 0; i < rank.Length; i++)
                    {
                        double TotalRate = (savings.SEarlyDeposit * (rank[i] / 100) * (savings.STerm * 30.5)) / 365;
                        double Total = savings.SEarlyDeposit + TotalRate;

                        ViewBag.Earlysaving = savings.SEarlyDeposit.ToString("0.00");
                        ViewBag.Ratesaving = TotalRate.ToString("0.00");
                        ViewBag.Totalsaving = Total.ToString("0.00");

                        List<Savings> listsave = new List<Savings>();
                        listsave.Add(new Savings { SEarlyDeposit = ViewBag.Earlysaving, SInterestRate = ViewBag.Ratesaving, STotal = ViewBag.Totalsaving });
                        _ = listsave[i];

                        ViewBag.orderRank = listsave.OrderByDescending(r => r.SInterestRate);
                    }

                }

                return View(savings);
            }

        public IActionResult CalFixed(FixedDeposit fixedDeposit)
        {
            fixedDeposit.FEarlyDeposit = Convert.ToDouble(HttpContext.Request.Form["Fmoney"].ToString());
            fixedDeposit.FInterestRate = Convert.ToDouble(HttpContext.Request.Form["Frate"].ToString());
            fixedDeposit.FTermperMonth = Convert.ToDouble(HttpContext.Request.Form["Fday"].ToString());

            if (fixedDeposit.FTermperMonth == 3)
            {
                double TotalRate = (fixedDeposit.FEarlyDeposit * (fixedDeposit.FInterestRate / 100) * 90) / 365;
                double Total = fixedDeposit.FEarlyDeposit + TotalRate;
                ViewBag.Earlysaving = fixedDeposit.FEarlyDeposit.ToString();
                ViewBag.Ratesaving = TotalRate.ToString();
                ViewBag.Totalsaving = Total.ToString();
            }
            if (fixedDeposit.FTermperMonth == 6)
            {
                double TotalRate = (fixedDeposit.FEarlyDeposit * (fixedDeposit.FInterestRate / 100) * 183) / 365;
                double Total = fixedDeposit.FEarlyDeposit + TotalRate;
                ViewBag.Earlysaving = fixedDeposit.FEarlyDeposit.ToString();
                ViewBag.Ratesaving = TotalRate.ToString();
                ViewBag.Totalsaving = Total.ToString();
            }
            if (fixedDeposit.FTermperMonth == 12)
            {
                double TotalRate = (fixedDeposit.FEarlyDeposit * (fixedDeposit.FInterestRate / 100) * 365) / 365;
                double Total = fixedDeposit.FEarlyDeposit + TotalRate;
                ViewBag.Earlysaving = fixedDeposit.FEarlyDeposit.ToString();
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
