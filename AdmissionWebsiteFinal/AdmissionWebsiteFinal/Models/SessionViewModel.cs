﻿using AdmissionWebsiteFinal.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdmissionWebsiteFinal.Models
{
    public class SessionViewModel
    {
        public int Id { get; set; }
        [Required]
        [FirstDateLower]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }
        [Required]
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }
        [Required]
        public bool Active { get; set; }
        public bool ConfirmationStage { get; set; }
        public bool Expired { get { return EndDate < DateTime.Now; } }
        public IEnumerable<OptionViewModel> Options { get; set; }
        public static SessionViewModel CurrentActiveSession { get; set; }
    }
}
