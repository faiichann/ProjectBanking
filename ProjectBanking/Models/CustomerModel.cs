using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ProjectBanking.Models
{
    public class Customer
    {
        [Key]
        [Required(ErrorMessage = "กรุณากรอกเลขบัตรประชาชน")]
        [StringLength(13 , ErrorMessage = "กรุณากรอกเลขบัตรประชาชนให้ครบ13หลัก", MinimumLength = 13)]
        public string CustomerID { get; set; }
        [Required(ErrorMessage = "กรุณากรอกชื่อ - นามสกุล")]
        public string CustomerName { get; set; }
        [Required(ErrorMessage = "กรุณากรอกที่อยู่ปัจจุบัน")]
        public string CustomerAddress { get; set; }
        [Phone]
        [Required(ErrorMessage = "กรุณากรอกหมายเลขโทรศัพท์")]
        [StringLength(10 , ErrorMessage = "กรุณากรอกเบอร์ติดต่อให้ถูกต้อง" , MinimumLength = 9)]
        public string CustomerPhone { get; set; }

        [DisplayFormat(DataFormatString = "{0:MMMM-dd-yy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "กรุณาใส่วันที่")]
        public DateTime CustomerDate { get; set; }

        [DataType(DataType.ImageUrl)]
        public string CustomerImg { get; set; }
        public string BankSelect { get; set; }
    }
}
