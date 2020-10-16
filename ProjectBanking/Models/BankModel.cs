using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ProjectBanking.Models
{
    public class Bank
    {
        public string BankID { get; set; }
        public string BankName { get; set; }
        public string BankAddress { get; set; }
        public double BankInterestRate { get; set; }
        
    }
}
