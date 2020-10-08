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
        public string SBankID { get; set; }
        public string SInterestRate { get; set; }
        public string STerm { get; set; }
        public string SEarlyDeposit { get; set; }
        public string STotal { get; set; }
    }
    public class FixedDeposit
    {
        public string FBankID { get; set; }
        public string FInterestRate { get; set; }
        public string FTermperMonth { get; set; }
        public string FEarlyDeposit { get; set; }
        public string FTotal { get; set; }
    }
}
