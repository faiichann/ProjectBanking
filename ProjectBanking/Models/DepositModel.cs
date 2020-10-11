using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ProjectBanking.Models
{
    public class Savings
    {
        public Bank SBankID { get; set; }
        public double SInterestRate { get; set; }
        public double STerm { get; set; }
        public double SEarlyDeposit { get; set; }
        public double STotal { get; set; }
    }
    public class FixedDeposit
    {
        public Bank FBankID { get; set; }
        public string FInterestRate { get; set; }
        public string FTermperMonth { get; set; }
        public string FEarlyDeposit { get; set; }
        public string FTotal { get; set; }
    }
}
