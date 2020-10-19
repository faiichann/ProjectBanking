using System;
using System.IO;    
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
//using Grpc.Core;
//using iTextSharp.text;
//using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace ProjectBanking.Controllers
{
    public class HomeController : Controller
    {
        [Obsolete]
        IHostingEnvironment _env;

        [Obsolete]
        public HomeController(IHostingEnvironment environment)
        {
            _env = environment;
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

        public ActionResult cal1() 
        {
            ViewBag.listbank = AllBank();
            return View();
        }

        public IActionResult Save()
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
        public IActionResult Home1()
        {
        
            return View();
        }
        public IActionResult choose()
        {

            return View();
        }
        public IActionResult cal2()
        {
            ViewBag.listbank = AllBank();
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
                string bank = HttpContext.Request.Form["bank"].ToString();

                if (bank == "ธนาคารไทยพาณิชย์")
                {
                    ViewBag.bank = "ธนาคารไทยพาณิชย์".ToString();
            }
                if (bank == "ธนาคารกรุงศรีอยุธยา")
                {
                    ViewBag.bank = "ธนาคารกรุงศรีอยุธยา".ToString();
            }
                if (bank == "ธนาคารกสิกรไทย")
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
            listsave.Add(new Savings { SBankName = "SCB", SInterestRate = 0.375, SRate = 23, Sday = 12, Smoney = 10000, STotal = 10023 });
            listsave.Add(new Savings { SBankName = "Krungsri", SInterestRate = 1.1, SRate = 50, Sday = 12, Smoney = 10000, STotal = 10050 });
            listsave.Add(new Savings { SBankName = "KBank", SInterestRate = 0.865, SRate = 33, Sday = 12, Smoney = 10000, STotal = 10033});

            ViewBag.SaveRank = listsave.OrderByDescending(r => r.SInterestRate);

            return listsave;
        }
        public IActionResult CalSaving(Savings savings)
            {

            savings.Smoney = Convert.ToDouble(HttpContext.Request.Form["Smoney"].ToString());
                savings.Sday = Convert.ToInt32(HttpContext.Request.Form["Sday"].ToString());
                ViewBag.Sterm = savings.Sday.ToString("0");

            //SCB
            savings.SInterestRate = 0.25;
            double TotalRates1 = (savings.Smoney * (savings.SInterestRate / 100) * (savings.Sday * 30.5)) / 365;
            double Totals1 = savings.Smoney + TotalRates1;

            ViewBag.Earlysavingb1 = savings.Smoney.ToString("0.00");
            ViewBag.Ratesavingb1 = TotalRates1.ToString("0.00");
            ViewBag.Totalsavingb1 = Totals1.ToString("0.00");

            //Krungsri
            savings.SInterestRate = 0.35;
            double TotalRates2 = (savings.Smoney * (savings.SInterestRate / 100) * (savings.Sday * 30.5)) / 365;
            double Totals2 = savings.Smoney + TotalRates2;

            ViewBag.Earlysavingb2 = savings.Smoney.ToString("0.00");
            ViewBag.Ratesavingb2 = TotalRates2.ToString("0.00");
            ViewBag.Totalsavingb2 = Totals2.ToString("0.00");

            //KBANK
            savings.SInterestRate = 0.20;
            double TotalRates3 = (savings.Smoney * (savings.SInterestRate / 100) * (savings.Sday * 30.5)) / 365;
            double Totals3 = savings.Smoney + TotalRates3;

            ViewBag.Earlysavingb3 = savings.Smoney.ToString("0.00");
            ViewBag.Ratesavingb3 = TotalRates3.ToString("0.00");
            ViewBag.Totalsavingb3 = Totals3.ToString("0.00");


            return View("cal1");
        }
        public IActionResult CalFixed(FixedDeposit fixedDeposit)
        {
                fixedDeposit.Fmoney = Convert.ToDouble(HttpContext.Request.Form["Fmoney"].ToString());
                fixedDeposit.Fmonth = Convert.ToDouble(HttpContext.Request.Form["Fmonth"].ToString());
                fixedDeposit.Fday = Convert.ToDouble(HttpContext.Request.Form["Fday"].ToString());
                ViewBag.Fterm = fixedDeposit.Fday;

                if (fixedDeposit.Fday == 3)
                {
                    double Sum3month = fixedDeposit.Fmonth * 3;
                    ViewBag.Monthfixsaving1 = Sum3month.ToString("0.00");
                    double Summoney1 = fixedDeposit.Fmoney + Sum3month;

                    //SCB
                    fixedDeposit.FInterestRate = 0.37;

                    double TotalRateb1 = (Summoney1 * (fixedDeposit.FInterestRate / 100) * 90) / 365;
                    double Totalb1 = Summoney1 + TotalRateb1;
                    ViewBag.Earlyfixsavingb1 = fixedDeposit.Fmoney.ToString("0.00");
                    ViewBag.Monthlyfixsavingb1 = fixedDeposit.Fmonth.ToString("0.00");
                    ViewBag.Ratesfixsavingb1 = TotalRateb1.ToString("0.00");
                    ViewBag.Totalfixsavingb1 = Totalb1.ToString("0.00");
                    ViewBag.InterestRateb1 = fixedDeposit.FInterestRate.ToString("0.00");
                    ViewBag.Summoneyb1 = Summoney1.ToString("0.00");

                //KBANK 
                fixedDeposit.FInterestRate = 0.35;

                    double TotalRateb2 = (Summoney1 * (fixedDeposit.FInterestRate / 100) * 90) / 365;
                    double Totalb2 = Summoney1 + TotalRateb2;
                    ViewBag.Earlyfixsavingb2 = fixedDeposit.Fmoney.ToString("0.00");
                    ViewBag.Monthlyfixsavingb2 = fixedDeposit.Fmonth.ToString("0.00");
                    ViewBag.Ratesfixsavingb2 = TotalRateb2.ToString("0.00");
                    ViewBag.Totalfixsavingb2 = Totalb2.ToString("0.00");
                    ViewBag.InterestRateb2 = fixedDeposit.FInterestRate.ToString("0.00");
                    ViewBag.Summoneyb2 = Summoney1.ToString("0.00");

                //Krungsri
                fixedDeposit.FInterestRate = 0.38;

                    double TotalRateb3 = (Summoney1 * (fixedDeposit.FInterestRate / 100) * 90) / 365;
                    double Totalb3 = Summoney1 + TotalRateb3;
                    ViewBag.Earlyfixsavingb3 = fixedDeposit.Fmoney.ToString("0.00");
                    ViewBag.Monthlyfixsavingb3 = fixedDeposit.Fmonth.ToString("0.00");
                    ViewBag.Ratesfixsavingb3 = TotalRateb3.ToString("0.00");
                    ViewBag.Totalfixsavingb3 = Totalb3.ToString("0.00");
                    ViewBag.InterestRateb3 = fixedDeposit.FInterestRate.ToString("0.00");
                    ViewBag.Summoneyb3 = Summoney1.ToString("0.00");

            }
            
            if (fixedDeposit.Fday == 6)
            {
                double Sum6month = fixedDeposit.Fmonth * 6;
                ViewBag.Monthfixsaving2 = Sum6month.ToString("0.00");
                double Summoney2 = fixedDeposit.Fmoney + Sum6month;

                //SCB
                fixedDeposit.FInterestRate = 0.49;
                
                double TotalRateb1 = (Summoney2 * (fixedDeposit.FInterestRate / 100) * 183) / 365;
                double Totalb1 = Summoney2 + TotalRateb1;
                ViewBag.Earlyfixsavingb1 = fixedDeposit.Fmoney.ToString("0.00");
                ViewBag.Monthlyfixsavingb1 = fixedDeposit.Fmonth.ToString("0.00");
                ViewBag.Ratesfixsavingb1 = TotalRateb1.ToString("0.00");
                ViewBag.Totalfixsavingb1 = Totalb1.ToString("0.00");
                ViewBag.InterestRateb1 = fixedDeposit.FInterestRate.ToString("0.00");
                ViewBag.Summoneyb1 = Summoney2.ToString("0.00");

                //KBANK 
                fixedDeposit.FInterestRate = 0.45;

                double TotalRateb2 = (Summoney2 * (fixedDeposit.FInterestRate / 100) * 183) / 365;
                double Totalb2 = Summoney2 + TotalRateb2;
                ViewBag.Earlyfixsavingb2 = fixedDeposit.Fmoney.ToString("0.00");
                ViewBag.Monthlyfixsavingb2 = fixedDeposit.Fmonth.ToString("0.00");
                ViewBag.Ratesfixsavingb2 = TotalRateb2.ToString("0.00");
                ViewBag.Totalfixsavingb2 = Totalb2.ToString("0.00");
                ViewBag.InterestRateb2 = fixedDeposit.FInterestRate.ToString("0.00");
                ViewBag.Summoneyb2 = Summoney2.ToString("0.00");

                //Krungsri
                fixedDeposit.FInterestRate = 0.50;

                double TotalRateb3 = (Summoney2 * (fixedDeposit.FInterestRate / 100) * 183) / 365;
                double Totalb3 = Summoney2 + TotalRateb3;
                ViewBag.Earlyfixsavingb3 = fixedDeposit.Fmoney.ToString("0.00");
                ViewBag.Monthlyfixsavingb3 = fixedDeposit.Fmonth.ToString("0.00");
                ViewBag.Ratesfixsavingb3 = TotalRateb3.ToString("0.00");
                ViewBag.Totalfixsavingb3 = Totalb3.ToString("0.00");
                ViewBag.InterestRateb3 = fixedDeposit.FInterestRate.ToString("0.00");
                ViewBag.Summoneyb3 = Summoney2.ToString("0.00");
            }

            if (fixedDeposit.Fday == 12)
            {
                double Sum12month = fixedDeposit.Fmonth * 12;
                ViewBag.Monthfixsaving2 = Sum12month.ToString("0.00");
                double Summoney3 = fixedDeposit.Fmoney + Sum12month;

                //SCB
                fixedDeposit.FInterestRate = 0.49;

                double TotalRateb1 = (Summoney3 * (fixedDeposit.FInterestRate / 100) * 365) / 365;
                double Totalb1 = Summoney3 + TotalRateb1;
                ViewBag.Earlyfixsavingb1 = fixedDeposit.Fmoney.ToString("0.00");
                ViewBag.Monthlyfixsavingb1 = fixedDeposit.Fmonth.ToString("0.00");
                ViewBag.Ratesfixsavingb1 = TotalRateb1.ToString("0.00");
                ViewBag.Totalfixsavingb1 = Totalb1.ToString("0.00");
                ViewBag.InterestRateb1 = fixedDeposit.FInterestRate.ToString("0.00");
                ViewBag.Summoneyb1 = Summoney3.ToString("0.00");

                //KBANK 
                fixedDeposit.FInterestRate = 0.45;

                double TotalRateb2 = (Summoney3 * (fixedDeposit.FInterestRate / 100) * 365) / 365;
                double Totalb2 = Summoney3 + TotalRateb2;
                ViewBag.Earlyfixsavingb2 = fixedDeposit.Fmoney.ToString("0.00");
                ViewBag.Monthlyfixsavingb2 = fixedDeposit.Fmonth.ToString("0.00");
                ViewBag.Ratesfixsavingb2 = TotalRateb2.ToString("0.00");
                ViewBag.Totalfixsavingb2 = Totalb2.ToString("0.00");
                ViewBag.InterestRateb2 = fixedDeposit.FInterestRate.ToString("0.00");
                ViewBag.Summoneyb2 = Summoney3.ToString("0.00");

                //Krungsri
                fixedDeposit.FInterestRate = 0.50;

                double TotalRateb3 = (Summoney3 * (fixedDeposit.FInterestRate / 100) * 236) / 365;
                double Totalb3 = Summoney3 + TotalRateb3;
                ViewBag.Earlyfixsavingb3 = fixedDeposit.Fmoney.ToString("0.00");
                ViewBag.Monthlyfixsavingb3 = fixedDeposit.Fmonth.ToString("0.00");
                ViewBag.Ratesfixsavingb3 = TotalRateb3.ToString("0.00");
                ViewBag.Totalfixsavingb3 = Totalb3.ToString("0.00");
                ViewBag.InterestRateb3 = fixedDeposit.FInterestRate.ToString("0.00");
                ViewBag.Summoneyb3 = Summoney3.ToString("0.00");
            }
                return View("cal2",fixedDeposit);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [Obsolete]
        public async Task<IActionResult> ImageUpload(IFormFile file)
        {
            if(file !=null && file.Length > 0)
            {
                var imagePath = @"\Upload\Images\";
                var uploadPath = _env.WebRootPath + imagePath;

                if (!Directory.Exists(uploadPath))
                {
                    Directory.CreateDirectory(uploadPath);
                }

                var uniqFileName = Guid.NewGuid().ToString();
                var filename = Path.GetFileName(uniqFileName + "." + file.FileName.Split(".")[1].ToLower());
                string fullPath = uploadPath + filename;

                imagePath = imagePath + @"\";
                var filePath = @".." + Path.Combine(imagePath, filename);

                using (var fileStream = new FileStream(fullPath , FileMode.Create))
                {
                    await file.CopyToAsync(fileStream);
                }

                ViewData["FileLocation"] = filePath;
            }
            return View("../Home/Complete", "Formbank");
        }


    }
}
