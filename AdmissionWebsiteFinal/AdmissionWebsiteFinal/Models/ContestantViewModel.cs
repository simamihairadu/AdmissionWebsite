﻿using AdmissionWebsiteFinal.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdmissionWebsiteFinal.Models
{
    public class ContestantViewModel : IContestant
    {
        [Required]
        [CNP]
        [Display(Name = "CNP")]
        public string Id { get; set; }
        [Required]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        [Required]
        [Display(Name = "Address")]
        public string Adress { get; set; }
        [Required]
        [DateOfBirthRange]
        [Display(Name = "Date of birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        public string GetId()
        {
            return Id;
        }
    }
}
