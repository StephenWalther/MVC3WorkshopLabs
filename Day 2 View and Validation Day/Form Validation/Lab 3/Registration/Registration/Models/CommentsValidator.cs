using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Registration.Models
{
    public class CommentsValidator
    {
        public static ValidationResult ValidateComments(string Comments, ValidationContext context) {

            if (!Comments.Contains("wow")) {
                return new ValidationResult("Comments doesn't contain 'wow'", new[] { "Comments"});
            }
            return ValidationResult.Success;
        }
    }
}