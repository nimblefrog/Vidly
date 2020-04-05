using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class StockRange : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var movie = (Movie)validationContext.ObjectInstance;

            return movie.NumberInStock == 0
                ? new ValidationResult("The field Number in Stock must be between 1 and 20.")
                : ValidationResult.Success;
        }
    }
}