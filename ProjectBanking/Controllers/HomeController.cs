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
using SelectPdf;
using System.Drawing.Imaging;
using Grpc.Core;

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
            ViewBag.getbank = Formbank();
            return View();
        }
        public ActionResult Fixed()
        {
            ViewBag.listbank = AllBank();
            return View();
        }

        public ActionResult Save() 
        {
            ViewBag.listbank = AllBank();
            return View();
        }

        public IActionResult Formbank()
        {
            ViewBag.listbank = AllBank();
            return View();
        }
        public IActionResult Complete()
        {
            ViewBag.bankpage = Page();
            return View();
        }
        /*public class PdfImageElement : PdfElement
        {

        }*/
        public IActionResult Pdf(string html)
        {
            html = html.Replace("StrTag", "<").Replace("EndTag", ">");

            HtmlToPdf oHtmlToPdf = new HtmlToPdf();
            PdfDocument opdfDocument = oHtmlToPdf.ConvertHtmlString(html);

            // get image path
            //string imgFile = Server.MapPath("~/files/logo.png");

            // define a rendering result object
           // PdfRenderingResult result;

            // create image element from file path with real image size
            //PdfImageElement img1 = new PdfImageElement(0, 0, imgFile);
            //result = opdfDocument.AddPage(img1);

            byte[] pdf = opdfDocument.Save();

            opdfDocument.Close();

            return File(
                pdf,
                "application/pdf",
                "InformationForBank.pdf");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Formbank(Customer info)
        {

            if (ModelState.IsValid)
            {
                return View("Complete", info);
            }
            return View("info");
        }

        public IActionResult Page()
        {
                int bank = Convert.ToInt32(HttpContext.Request.Form["bank"].ToString());

                if (bank == 1)
                {
                    ViewBag.bank = "ธนาคารไทยพาณิชย์".ToString();
            }
                if (bank == 2)
                {
                    ViewBag.bank = "ธนาคารกรุงศรีอยุธยา".ToString();
            }
                if (bank == 3)
                {
                    ViewBag.bank = "ธนาคารกสิกรไทย".ToString();
            }

            return View("Formbank");
        }

        public List<Bank> AllBank()
        {
            List<Bank> listbank = new List<Bank>();
            listbank.Add(new Bank { BankID = "001", BankName = "ธนาคารไทยพาณิชย์", BankAddress = "Bankok" , BankInterestRate = 0.375});
            listbank.Add(new Bank { BankID = "002", BankName = "ธนาคารกรุงศรีอยุธยา", BankAddress = "Bankok", BankInterestRate = 1.1 });
            listbank.Add(new Bank { BankID = "003", BankName = "ธนาคารกสิกรไทย", BankAddress = "Bankok", BankInterestRate = 0.865 });

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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CalSaving(Savings savings)
            {
                savings.SEarlyDeposit = Convert.ToDouble(HttpContext.Request.Form["Smoney"].ToString());
                savings.STerm = Convert.ToDouble(HttpContext.Request.Form["Sday"].ToString());
                ViewBag.Sterm = savings.STerm.ToString("0");

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

                return View("Save", savings);    
            }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CalFixed(FixedDeposit fixedDeposit)
        {
                fixedDeposit.FEarlyDeposit = Convert.ToDouble(HttpContext.Request.Form["Fmoney"].ToString());
                fixedDeposit.FMonthDeposit = Convert.ToDouble(HttpContext.Request.Form["Fmonth"].ToString());
                fixedDeposit.FTermperMonth = Convert.ToDouble(HttpContext.Request.Form["Fday"].ToString());
                ViewBag.Fterm = fixedDeposit.FTermperMonth;

                if (fixedDeposit.FTermperMonth == 3)
                {
                    double Sum3month = fixedDeposit.FMonthDeposit * 3;
                    ViewBag.Monthfixsaving1 = Sum3month.ToString("0.00");
                    double Summoney1 = fixedDeposit.FEarlyDeposit + Sum3month;

                    //SCB
                    fixedDeposit.FInterestRate = 0.375;

                    double TotalRateb1 = (Summoney1 * (fixedDeposit.FInterestRate / 100) * 90) / 365;
                    double Totalb1 = Summoney1 + TotalRateb1;
                    ViewBag.Earlyfixsavingb1 = fixedDeposit.FEarlyDeposit.ToString("0.00");
                    ViewBag.Ratesfixavingb1 = TotalRateb1.ToString("0.00");
                    ViewBag.Totalfixsavingb1 = Totalb1.ToString("0.00");
                    ViewBag.Summoneyb1 = Summoney1;

                    //KBANK 
                    fixedDeposit.FInterestRate = 0.87;

                    double TotalRateb2 = (Summoney1 * (fixedDeposit.FInterestRate / 100) * 90) / 365;
                    double Totalb2 = Summoney1 + TotalRateb2;
                    ViewBag.Earlyfixsavingb2 = fixedDeposit.FEarlyDeposit.ToString("0.00");
                    ViewBag.Ratesfixavingb2 = TotalRateb2.ToString("0.00");
                    ViewBag.Totalfixsavingb2 = Totalb2.ToString("0.00");
                    ViewBag.Summoneyb2 = Summoney1;

                    //Krungsri
                    fixedDeposit.FInterestRate = 1.1;

                    double TotalRateb3 = (Summoney1 * (fixedDeposit.FInterestRate / 100) * 90) / 365;
                    double Totalb3 = Summoney1 + TotalRateb3;
                    ViewBag.Earlyfixsavingb3 = fixedDeposit.FEarlyDeposit.ToString("0.00");
                    ViewBag.Ratesfixavingb3 = TotalRateb3.ToString("0.00");
                    ViewBag.Totalfixsavingb3 = Totalb3.ToString("0.00");
                    ViewBag.Summoneyb3 = Summoney1;

                }
            
            if (fixedDeposit.FTermperMonth == 6)
            {
                double Sum6month = fixedDeposit.FMonthDeposit * 6;
                ViewBag.Monthfixsaving2 = Sum6month.ToString("0.00");
                double Summoney2 = fixedDeposit.FEarlyDeposit + Sum6month;

                //SCB
                fixedDeposit.FInterestRate = 0.375;
                
                double TotalRateb1 = (Summoney2 * (fixedDeposit.FInterestRate / 100) * 183) / 365;
                double Totalb1 = Summoney2 + TotalRateb1;
                ViewBag.Earlyfixsavingb1 = fixedDeposit.FEarlyDeposit.ToString("0.00");
                ViewBag.Ratesfixavingb1 = TotalRateb1.ToString("0.00");
                ViewBag.Totalfixsavingb1 = Totalb1.ToString("0.00");
                ViewBag.Summoneyb1 = Summoney2;

                //KBANK 
                fixedDeposit.FInterestRate = 0.87;

                double TotalRateb2 = (Summoney2 * (fixedDeposit.FInterestRate / 100) * 183) / 365;
                double Totalb2 = Summoney2 + TotalRateb2;
                ViewBag.Earlyfixsavingb2 = fixedDeposit.FEarlyDeposit.ToString("0.00");
                ViewBag.Ratesfixavingb2 = TotalRateb2.ToString("0.00");
                ViewBag.Totalfixsavingb2 = Totalb2.ToString("0.00");
                ViewBag.Summoneyb2 = Summoney2;

                //Krungsri
                fixedDeposit.FInterestRate = 1.1;

                double TotalRateb3 = (Summoney2 * (fixedDeposit.FInterestRate / 100) * 183) / 365;
                double Totalb3 = Summoney2 + TotalRateb3;
                ViewBag.Earlyfixsavingb3 = fixedDeposit.FEarlyDeposit.ToString("0.00");
                ViewBag.Ratesfixavingb3 = TotalRateb3.ToString("0.00");
                ViewBag.Totalfixsavingb3 = Totalb3.ToString("0.00");
                ViewBag.Summoneyb3 = Summoney2;
            }

            if (fixedDeposit.FTermperMonth == 12)
            {
                double Sum12month = fixedDeposit.FMonthDeposit * 12;
                ViewBag.Monthfixsaving2 = Sum12month.ToString("0.00");
                double Summoney3 = fixedDeposit.FEarlyDeposit + Sum12month;

                //SCB
                fixedDeposit.FInterestRate = 0.375;

                double TotalRateb1 = (Summoney3 * (fixedDeposit.FInterestRate / 100) * 365) / 365;
                double Totalb1 = Summoney3 + TotalRateb1;
                ViewBag.Earlyfixsavingb1 = fixedDeposit.FEarlyDeposit.ToString("0.00");
                ViewBag.Ratesfixavingb1 = TotalRateb1.ToString("0.00");
                ViewBag.Totalfixsavingb1 = Totalb1.ToString("0.00");
                ViewBag.Summoney1 = Summoney3;

                //KBANK 
                fixedDeposit.FInterestRate = 0.87;

                double TotalRateb2 = (Summoney3 * (fixedDeposit.FInterestRate / 100) * 365) / 365;
                double Totalb2 = Summoney3 + TotalRateb2;
                ViewBag.Earlyfixsavingb2 = fixedDeposit.FEarlyDeposit.ToString("0.00");
                ViewBag.Ratesfixavingb2 = TotalRateb2.ToString("0.00");
                ViewBag.Totalfixsavingb2 = Totalb2.ToString("0.00");
                ViewBag.Summoney2 = Summoney3;

                //Krungsri
                fixedDeposit.FInterestRate = 1.1;

                double TotalRateb3 = (Summoney3 * (fixedDeposit.FInterestRate / 100) * 236) / 365;
                double Totalb3 = Summoney3 + TotalRateb3;
                ViewBag.Earlyfixsavingb3 = fixedDeposit.FEarlyDeposit.ToString("0.00");
                ViewBag.Ratesfixavingb3 = TotalRateb3.ToString("0.00");
                ViewBag.Totalfixsavingb3 = Totalb3.ToString("0.00");
                ViewBag.Summoney3 = Summoney3;


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
