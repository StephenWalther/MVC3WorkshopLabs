using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Registration.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "First Name is required.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        [Remote("ValidateLastName", "Home" ,ErrorMessage= "Invalid Last Name")]      
        public string LastName { get; set; }

        [CustomValidation(typeof(CommentsValidator), "ValidateComments")]
        public string Comments { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        [Compare("ConfirmPassword", ErrorMessage = "Password and Confirm Passwords must be same.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please retype password again.")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [RegularExpression(@"\d{3}-\d{2}-\d{4}", ErrorMessage = "Invalid SSN (correct format is xxx-xx-xxxx)")]
        public string SSN { get; set; }       
    }
}