using System;
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

            double SFirstmoney = Convert.ToInt32(HttpContext.Request.Form["Smoney"].ToString());
            double SRate = Convert.ToInt32(HttpContext.Request.Form["Srate"].ToString());
            int STerm = Convert.ToInt32(HttpContext.Request.Form["Sday"].ToString());
           
            /* SCB */
            SRate = 0.25;
            double TotalRate1 = (SFirstmoney * (SRate/100) * (STerm*30.5) / 365);
            double Total1 = SFirstmoney + TotalRate1;
            ViewBag.Earlysaving1 = SFirstmoney.ToString("0.00");
            ViewBag.Ratesaving1 = TotalRate1.ToString("0.00");
            ViewBag.Rate1 = SRate.ToString("0.00");
            ViewBag.Totalsaving1 = Total1.ToString("0.00");

            /* KBANK */
            SRate = 0.12;
            double TotalRate2 = (SFirstmoney * (SRate / 100) * (STerm * 30.5) / 365);
            double Total2 = SFirstmoney + TotalRate2;
            ViewBag.Earlysaving2 = SFirstmoney.ToString("0.00");
            ViewBag.Ratesaving2 = TotalRate2.ToString("0.00");
            ViewBag.Rate2 = SRate.ToString("0.00");
            ViewBag.Totalsaving2 = Total1.ToString("0.00");

            /* Krungsri */
            SRate = 1.1;
            double TotalRate3 = (SFirstmoney * (SRate / 100) * (STerm * 30.5) / 365);
            double Total3 = SFirstmoney + TotalRate3;
            ViewBag.Earlysaving3 = SFirstmoney.ToString("0.00");
            ViewBag.Ratesaving3 = TotalRate1.ToString("0.00");
            ViewBag.Rate3 = SRate.ToString("0.00");
            ViewBag.Totalsaving3 = Total3.ToString("0.00");

            List<string> rangS = new List<string>()
                {
                      ViewBag.Totalsaving1,ViewBag.Totalsaving2,ViewBag.Totalsaving3
                };
            List<string> liRate = rangS.OrderBy(number => number).ToList();
            foreach (string number in liRate)
                ViewBag.read = number;
            return View("Index");
        }
        public IActionResult CalFixed()
        {
            double Firstmoney = Convert.ToInt32(HttpContext.Request.Form["Fmoney"].ToString());
            double Secondmoney = Convert.ToInt32(HttpContext.Request.Form["Smoney"].ToString());
            double Rate = Convert.ToInt32(HttpContext.Request.Form["Frate"].ToString());
            int Term = Convert.ToInt32(HttpContext.Request.Form["Fday"].ToString());

            if (Term == 3)
            {  
                /* SCB */
                Rate = 0.375;
                double TotalMoney4 = Firstmoney + (Secondmoney * 3);
                double TotalRate4 = ((Firstmoney + (Secondmoney * 3)) * (Rate / 100) * 90) / 365;
                double Total4 = TotalMoney4 + TotalRate4;
                ViewBag.Earlysaving4 = Firstmoney.ToString("0.00");
                ViewBag.Lastsaving4 = TotalMoney4.ToString("0.00");
                ViewBag.Ratesaving4 = TotalRate4.ToString("0.00");
                ViewBag.Rate4 = Rate.ToString("0.000");
                ViewBag.Totalsaving4 = Total4.ToString("0.00");

                /* KBANK */
                Rate = 0.37;
                double TotalMoney5 = Firstmoney + (Secondmoney * 3);
                double TotalRate5 = ((Firstmoney + (Secondmoney * 3)) * (Rate / 100) * 90) / 365;
                double Total5 = TotalMoney5 + TotalRate5;
                ViewBag.Earlysaving5 = Firstmoney.ToString("0.00");
                ViewBag.Lastsaving5 = TotalMoney5.ToString("0.00");
                ViewBag.Ratesaving5 = TotalRate5.ToString("0.00");
                ViewBag.Rate5 = Rate.ToString("0.00");
                ViewBag.Totalsaving5 = Total5.ToString("0.00");

                /* Krungsri */
                Rate = 0.375;
                double TotalMoney6 = Firstmoney + (Secondmoney * 3);
                double TotalRate6 = ((Firstmoney + (Secondmoney * 3)) * (Rate / 100) * 90) / 365;
                double Total6 = TotalMoney6 + TotalRate6;
                ViewBag.Earlysaving6 = Firstmoney.ToString("0.00");
                ViewBag.Lastsaving6 = TotalMoney6.ToString("0.00");
                ViewBag.Ratesaving6 = TotalRate6.ToString("0.00");
                ViewBag.Rate6 = Rate.ToString("0.000");
                ViewBag.Totalsaving6 = Total6.ToString("0.00");
            }
            if (Term == 6)
            {
                /* SCB */
                Rate = 0.50;
                double TotalMoney4 = Firstmoney + (Secondmoney * 6);
                double TotalRate4 = ((Firstmoney +(Secondmoney * 6)) * (Rate / 100) * 183) / 365;
                double Total4 = TotalMoney4 + TotalRate4;
                ViewBag.Earlysaving4 = Firstmoney.ToString("0.00");
                ViewBag.Lastsaving4 = TotalMoney4.ToString("0.00");
                ViewBag.Ratesaving4 = TotalRate4.ToString("0.00");
                ViewBag.Rate4 = Rate.ToString("0.00");
                ViewBag.Totalsaving4 = Total4.ToString("0.00");

                /* KBANK */
                Rate = 0.45;
                double TotalMoney5 = Firstmoney + (Secondmoney * 6);
                double TotalRate5 = ((Firstmoney + (Secondmoney * 6)) * (Rate / 100) * 183) / 365;
                double Total5 = TotalMoney5 + TotalRate5;
                ViewBag.Earlysaving5 = Firstmoney.ToString("0.00");
                ViewBag.Lastsaving5 = TotalMoney5.ToString("0.00");
                ViewBag.Ratesaving5 = TotalRate5.ToString("0.00");
                ViewBag.Rate5 = Rate.ToString("0.00");
                ViewBag.Totalsaving5 = Total5.ToString("0.00");

                /* Krungsri */
                Rate = 0.50;
                double TotalMoney6 = Firstmoney + (Secondmoney * 6);
                double TotalRate6 = ((Firstmoney + (Secondmoney * 6)) * (Rate / 100) * 183) / 365;
                double Total6 = TotalMoney6 + TotalRate6;
                ViewBag.Earlysaving6 = Firstmoney.ToString("0.00");
                ViewBag.Lastsaving6 = TotalMoney6.ToString("0.00");
                ViewBag.Ratesaving6 = TotalRate6.ToString("0.00");
                ViewBag.Rate6 = Rate.ToString("0.00");
                ViewBag.Totalsaving6 = Total6.ToString("0.00");
            }
        
            if (Term == 12)
            {
                /* SCB */
                Rate = 0.50;
                double TotalMoney4 = Firstmoney + (Secondmoney * 12);
                double TotalRate4 = ((Firstmoney + (Secondmoney * 12)) * (Rate / 100) * 365) / 365;
                double Total4 = TotalMoney4 + TotalRate4;
                ViewBag.Earlysaving4 = Firstmoney.ToString("0.00");
                ViewBag.Lastsaving4 = TotalMoney4.ToString("0.00");
                ViewBag.Ratesaving4 = TotalRate4.ToString("0.00");
                ViewBag.Rate4 = Rate.ToString("0.00");
                ViewBag.Totalsaving4 = Total4.ToString("0.00");

                /* KBANK */
                Rate = 0.45;
                double TotalMoney5 = Firstmoney + (Secondmoney * 12);
                double TotalRate5 = ((Firstmoney + (Secondmoney * 12)) * (Rate / 100) * 365) / 365;
                double Total5 = TotalMoney5 + TotalRate5;
                ViewBag.Earlysaving5 = Firstmoney.ToString("0.00");
                ViewBag.Lastsaving5 = TotalMoney5.ToString("0.00");
                ViewBag.Ratesaving5 = TotalRate5.ToString("0.00");
                ViewBag.Rate5 = Rate.ToString("0.00");
                ViewBag.Totalsaving5 = Total5.ToString("0.00");

                /* Krungsri */
                Rate = 0.50;
                double TotalMoney6 = Firstmoney + (Secondmoney * 12);
                double TotalRate6 = ((Firstmoney + (Secondmoney * 12)) * (Rate / 100) * 365) / 365;
                double Total6 = TotalMoney6 + TotalRate6;
                ViewBag.Earlysaving6 = Firstmoney.ToString("0.00");
                ViewBag.Lastsaving6 = TotalMoney6.ToString("0.00");
                ViewBag.Ratesaving6 = TotalRate6.ToString("0.00");
                ViewBag.Rate6 = Rate.ToString("0.00");
                ViewBag.Totalsaving6 = Total6.ToString("0.00");
            }

            List<string> rangF = new List<string>()
                {
                      ViewBag.Totalsaving4,ViewBag.Totalsaving5,ViewBag.Totalsaving6
                };
            List<string> liRate = rangF.OrderBy(number => number).ToList();
            foreach (string number in liRate)
                ViewBag.readF = number;
            return View("Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
