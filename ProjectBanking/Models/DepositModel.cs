﻿using System;
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
        [Range(0,12,ErrorMessage = "กรุณาใส่จำนวนเดือน")]
        public double STerm { get; set; }
        [Required(ErrorMessage = "กรุณาใส่เงินฝากต้น")]
        [Display(Name = "เงินฝากต้น")]
        public double SEarlyDeposit { get; set; }

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

        [Display(Name = "ระยะฝาก/เดือน")]
        public double FTermperMonth { get; set; }

        [Display(Name = "เงินฝากต้น")]
        public double FEarlyDeposit { get; set; }

        [Display(Name = "เงินฝากรวม")]
        public double FMonthDeposit { get; set; }

        [Display(Name = "เงินฝากทั้งหมด")]
        public double FTotal { get; set; }
    }
}
