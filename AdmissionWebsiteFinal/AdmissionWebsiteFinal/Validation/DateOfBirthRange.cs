using AdmissionWebsiteFinal.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdmissionWebsiteFinal.Validation
{
    public class DateOfBirthRange : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var contestant = (ContestantViewModel)validationContext.ObjectInstance;

            if(contestant.DateOfBirth < DateTime.Now && contestant.DateOfBirth > Convert.ToDateTime("01/01/1900"))
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("Date out of range.");
        }
    }
}
