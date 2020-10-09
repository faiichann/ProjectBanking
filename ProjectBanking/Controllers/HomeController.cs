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
            double Firstmoney = Convert.ToInt32(HttpContext.Request.Form["Smoney"].ToString());
            double Rate = Convert.ToInt32(HttpContext.Request.Form["Srate"].ToString());
            int Term = Convert.ToInt32(HttpContext.Request.Form["Sday"].ToString());

            /* SCB */
            Rate = 0.25;
            double TotalRate1 = (Firstmoney * (Rate/100) * Term / 365);
            double Total1 = Firstmoney + TotalRate1;
            ViewBag.Earlysaving1 = Firstmoney.ToString("0.00");
            ViewBag.Ratesaving1 = TotalRate1.ToString("0.00");
            ViewBag.Rate1 = Rate.ToString("0.00");
            ViewBag.Totalsaving1 = Total1.ToString("0.00");

            /* KBANK */
            Rate = 0.25;
            double TotalRate2 = (Firstmoney * (Rate / 100) * Term / 365);
            double Total2 = Firstmoney + TotalRate2;
            ViewBag.Earlysaving2 = Firstmoney.ToString("0.00");
            ViewBag.Ratesaving2 = TotalRate2.ToString("0.00");
            ViewBag.Rate2 = Rate.ToString("0.00");
            ViewBag.Totalsaving2 = Total1.ToString("0.00");

            /* Krungsri */
            Rate = 0.25;
            double TotalRate3 = (Firstmoney * (Rate / 100) * Term / 365);
            double Total3 = Firstmoney + TotalRate3;
            ViewBag.Earlysaving3 = Firstmoney.ToString("0.00");
            ViewBag.Ratesaving3 = TotalRate1.ToString("0.00");
            ViewBag.Rate3 = Rate.ToString("0.00");
            ViewBag.Totalsaving3 = Total3.ToString("0.00");
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
                double TotalMoney1 = Firstmoney + (Secondmoney * 3);
                double TotalRate1 = ((Firstmoney + (Secondmoney * 3)) * (Rate / 100) * 90) / 365;
                double Total1 = TotalMoney1 + TotalRate1;
                ViewBag.Earlysaving1 = Firstmoney.ToString("0.00");
                ViewBag.Lastsaving1 = TotalMoney1.ToString("0.00");
                ViewBag.Ratesaving1 = TotalRate1.ToString("0.00");
                ViewBag.Rate1 = Rate.ToString("0.000");
                ViewBag.Totalsaving1 = Total1.ToString("0.00");

                /* KBANK */
                Rate = 0.37;
                double TotalMoney2 = Firstmoney + (Secondmoney * 3);
                double TotalRate2 = ((Firstmoney + (Secondmoney * 3)) * (Rate / 100) * 90) / 365;
                double Total2 = TotalMoney2 + TotalRate2;
                ViewBag.Earlysaving2 = Firstmoney.ToString("0.00");
                ViewBag.Lastsaving2 = TotalMoney2.ToString("0.00");
                ViewBag.Ratesaving2 = TotalRate2.ToString("0.00");
                ViewBag.Rate2 = Rate.ToString("0.00");
                ViewBag.Totalsaving2 = Total2.ToString("0.00");

                /* Krungsri */
                Rate = 0.375;
                double TotalMoney3 = Firstmoney + (Secondmoney * 3);
                double TotalRate3 = ((Firstmoney + (Secondmoney * 3)) * (Rate / 100) * 90) / 365;
                double Total3 = TotalMoney3 + TotalRate3;
                ViewBag.Earlysaving3 = Firstmoney.ToString("0.00");
                ViewBag.Lastsaving3 = TotalMoney3.ToString("0.00");
                ViewBag.Ratesaving3 = TotalRate3.ToString("0.00");
                ViewBag.Rate3 = Rate.ToString("0.000");
                ViewBag.Totalsaving3 = Total3.ToString("0.00");
            }
            if (Term == 6)
            {
                /* SCB */
                Rate = 0.50;
                double TotalMoney1 = Firstmoney + (Secondmoney * 6);
                double TotalRate1 = ((Firstmoney +(Secondmoney * 6)) * (Rate / 100) * 183) / 365;
                double Total1 = TotalMoney1 + TotalRate1;
                ViewBag.Earlysaving1 = Firstmoney.ToString("0.00");
                ViewBag.Lastsaving1 = TotalMoney1.ToString("0.00");
                ViewBag.Ratesaving1 = TotalRate1.ToString("0.00");
                ViewBag.Rate1 = Rate.ToString("0.00");
                ViewBag.Totalsaving1 = Total1.ToString("0.00");

                /* KBANK */
                Rate = 0.45;
                double TotalMoney2 = Firstmoney + (Secondmoney * 6);
                double TotalRate2 = ((Firstmoney + (Secondmoney * 6)) * (Rate / 100) * 183) / 365;
                double Total2 = TotalMoney2 + TotalRate2;
                ViewBag.Earlysaving2 = Firstmoney.ToString("0.00");
                ViewBag.Lastsaving2 = TotalMoney2.ToString("0.00");
                ViewBag.Ratesaving2 = TotalRate2.ToString("0.00");
                ViewBag.Rate2 = Rate.ToString("0.00");
                ViewBag.Totalsaving2 = Total2.ToString("0.00");

                /* Krungsri */
                Rate = 0.50;
                double TotalMoney3 = Firstmoney + (Secondmoney * 6);
                double TotalRate3 = ((Firstmoney + (Secondmoney * 6)) * (Rate / 100) * 183) / 365;
                double Total3 = TotalMoney3 + TotalRate3;
                ViewBag.Earlysaving3 = Firstmoney.ToString("0.00");
                ViewBag.Lastsaving3 = TotalMoney3.ToString("0.00");
                ViewBag.Ratesaving3 = TotalRate3.ToString("0.00");
                ViewBag.Rate3 = Rate.ToString("0.00");
                ViewBag.Totalsaving3 = Total3.ToString("0.00");
            }
        
            if (Term == 12)
            {
                /* SCB */
                Rate = 0.50;
                double TotalMoney1 = Firstmoney + (Secondmoney * 12);
                double TotalRate1 = ((Firstmoney + (Secondmoney * 12)) * (Rate / 100) * 365) / 365;
                double Total1 = TotalMoney1 + TotalRate1;
                ViewBag.Earlysaving1 = Firstmoney.ToString("0.00");
                ViewBag.Lastsaving1 = TotalMoney1.ToString("0.00");
                ViewBag.Ratesaving1 = TotalRate1.ToString("0.00");
                ViewBag.Rate1 = Rate.ToString("0.00");
                ViewBag.Totalsaving1 = Total1.ToString("0.00");

                /* KBANK */
                Rate = 0.45;
                double TotalMoney2 = Firstmoney + (Secondmoney * 12);
                double TotalRate2 = ((Firstmoney + (Secondmoney * 12)) * (Rate / 100) * 365) / 365;
                double Total2 = TotalMoney2 + TotalRate2;
                ViewBag.Earlysaving2 = Firstmoney.ToString("0.00");
                ViewBag.Lastsaving2 = TotalMoney2.ToString("0.00");
                ViewBag.Ratesaving2 = TotalRate2.ToString("0.00");
                ViewBag.Rate2 = Rate.ToString("0.00");
                ViewBag.Totalsaving2 = Total2.ToString("0.00");

                /* Krungsri */
                Rate = 0.50;
                double TotalMoney3 = Firstmoney + (Secondmoney * 12);
                double TotalRate3 = ((Firstmoney + (Secondmoney * 12)) * (Rate / 100) * 365) / 365;
                double Total3 = TotalMoney3 + TotalRate3;
                ViewBag.Earlysaving3 = Firstmoney.ToString("0.00");
                ViewBag.Lastsaving3 = TotalMoney3.ToString("0.00");
                ViewBag.Ratesaving3 = TotalRate3.ToString("0.00");
                ViewBag.Rate3 = Rate.ToString("0.00");
                ViewBag.Totalsaving3 = Total3.ToString("0.00");
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
