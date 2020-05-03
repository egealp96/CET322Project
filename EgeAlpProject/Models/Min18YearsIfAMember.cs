using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EgeAlpProject.Models
{
    public class Min18YearsIfAMember : ValidationAttribute
    {

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var owner = (Member)validationContext.ObjectInstance;

            if (owner.Birthdate == null)
            {
                return new ValidationResult("Dogum tarihi girmek zorundasiniz.");
            }

            var age = DateTime.Today.Year - owner.Birthdate.Value.Year;

            if (age >= 25)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Araba kiralamak icin en az 25 yasinda olmalisiniz.");
            }
        }

    }
}
