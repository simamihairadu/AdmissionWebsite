using AdmissionWebsiteFinal.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdmissionWebsiteFinal.Validation
{
    public class CNP : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var contestant = (IContestant)validationContext.ObjectInstance;

            if (contestant.GetId() != null && contestant.GetId().Length == 13 & CheckIfAllDigits(contestant.GetId()))
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("Invalid CNP format.");
        }

        private bool CheckIfAllDigits(string str)
        {
            return str.All(char.IsDigit);
        }
    }
}
