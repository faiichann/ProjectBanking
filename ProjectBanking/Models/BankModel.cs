using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ProjectBanking.Models
{
    public class GSBbank
    {
        public string GsbBankID { get; set; }
        public string GsbBankName { get; set; }
        public string GsbBankAddress { get; set; }
        public string GsbBankInterestRate { get; set; }
    }

    public class KTBbank
    {
        public string KtbBankID { get; set; }
        public string ktbBankName { get; set; }
        public string ktbBankAddress { get; set; }
        public string ktbBankInterestRate { get; set; }
    }

    public class SCBbank
    {
        public string ScbBankID { get; set; }
        public string ScbBankName { get; set; }
        public string ScbBankAddress { get; set; }
        public string ScbBankInterestRate { get; set; }
    }
}
