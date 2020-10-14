﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ProjectBanking.Models
{
    public class Customer
    {
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerImg{ get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d MM,y}", ApplyFormatInEditMode = true)]
        public DateTime CustomerDate { get; set; }
    }
}
