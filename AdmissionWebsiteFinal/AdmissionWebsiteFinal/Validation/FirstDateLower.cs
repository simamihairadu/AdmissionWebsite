using AdmissionWebsiteFinal.Data;
using AdmissionWebsiteFinal.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdmissionWebsiteFinal.Validation
{
    public class FirstDateLower : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var session = (SessionViewModel)validationContext.ObjectInstance;

            if(session.StartDate < session.EndDate)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("End date can't be earlier than start date.");
        }
    }
}
