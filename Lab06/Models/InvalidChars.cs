using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace Lab06.Models
{
    public class InvalidChars : ValidationAttribute
    {
        public InvalidChars(int invalidChars)
            :base("{0} Invalid Chars.")
        {
            _invalidChars = invalidChars;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
          if (value != null)
            {
                var valueAsString = value.ToString();
                if (valueAsString.Split(' ').Length > _invalidChars)
                {
                    var errorMessage = FormatErrorMessage(validationContext.DisplayName);
                    return new ValidationResult(errorMessage);
                }

            }


            return ValidationResult.Success;
        }
        private readonly int _invalidChars;
    }
}