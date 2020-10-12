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
        public Bank SBankID { get; set; }
        public double SInterestRate { get; set; }
        public double STerm { get; set; }
        public double SEarlyDeposit { get; set; }
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
