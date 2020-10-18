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
        [Required(ErrorMessage = "กรุณาใส่จำนวนเดือน")]
        [Range(1,12,ErrorMessage = "กรุณาใส่ไม่เกิน12เดือน")]
        public Int32 Sday { get; set; }

        [Required(ErrorMessage = "กรุณาใส่เงินฝาก")]
        [Range(500.00,double.MaxValue,ErrorMessage = "กรุณาใส่เงินขั้นต่ำ500บาท")]
        [Display(Name = "เงินฝากต้น")]
        public double Smoney { get; set; }

        [Display(Name = "เงินฝากทั้งหมด")]
        public double STotal { get; set; }
    }
    public class FixedDeposit
    {
        [Key]
        [Display(Name = "ลำดับ")]
        public Bank FBankID { get; set; }

        [Display(Name = "ชื่อธนาคาร")]
        public string FBankName { get; set; }

        [Display(Name = "อัตราดอกเบี้ย/ปี")]
        public double FInterestRate { get; set; }

        [Display(Name = "ดอกเบี้ยที่ได้รับ")]
        public double FRate { get; set; }

        [Display(Name = "ระยะเวลา(เดือน)")]
        [Required(ErrorMessage = "กรุณาเลือกระยะเวลาฝากประจำ")]
        public double Fday { get; set; }

        [Required(ErrorMessage = "กรุณาใส่เงินฝาก")]
        [Range(500.00, double.MaxValue, ErrorMessage = "กรุณาใส่เงินฝากเริ่มต้น ขั้นต่ำ500บาท")]
        [Display(Name = "เงินฝากเริ่มต้น")]
        public double Fmoney { get; set; }

        [Display(Name = "เงินฝากประจำรายเดือน")]
        [Required(ErrorMessage = "กรุณาใส่เงินฝากประจำ")]
        [Range(500.00,double.MaxValue, ErrorMessage = "กรุณาใส่เงินฝากประจำ ขั้นต่ำ500บาท")]
        public double Fmonth { get; set; }

        [Display(Name = "เงินที่ได้รับ")]
        public double FTotal { get; set; }
        [Display(Name = "เงินฝากรวม")]
        public double Fsum { get; set; }
    }
}
