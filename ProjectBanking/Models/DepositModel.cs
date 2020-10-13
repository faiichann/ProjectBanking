using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using ProjectBanking.Models;
using System.Data.Entity;

namespace ProjectBanking.Models
{
    public class Savings
    {
        [Key]
        [Display(Name ="ลำดับ")]
        public Bank SBankID { get; set; }

        [Display(Name = "ชื่อธนาคาร")]
        public string SBankName { get; set; }

        [Display(Name = "อัตราดอกเบี้ย/ปี")]
        public double SRate { get; set; }

        [Display(Name = "ดอกเบี้ยที่ได้รับ")]
        public double SInterestRate { get; set; }

        [Display(Name = "ระยะฝาก(เดือน)")]
        public double STerm { get; set; }

        [Display(Name = "เงินฝากต้น")]
        public double SEarlyDeposit { get; set; }

        [Display(Name = "เงินฝากทั้งหมด")]
        public double STotal { get; set; }
    }
    public class FixedDeposit
    {
        [Key]
        public Bank FBankID { get; set; }
        public double FInterestRate { get; set; }
        public double FTermperMonth { get; set; }
        public double FEarlyDeposit { get; set; }
        public double FTotal { get; set; }
    }
}
