﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BudgetGadget.Entity
{
    public class Earning
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Source is required")]
        public string Source { get; set; }

        [Required(ErrorMessage = "Amount is required")]
        [Display(Name = "Amount")]
        public long SourceAmount { get; set; }

       
        public string Date { get; set; }

       
        public string Month { get; set; }

        public Registration Registration { get; set; }
        public int RegistrationId { get; set; }
    }
}