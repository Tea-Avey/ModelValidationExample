using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using ModelValidationsExample.CustomValidations;
using System.ComponentModel.DataAnnotations;

namespace ModelValidationsExample.Models
{

    public class Person
    {
        //private static string requiredErrorMessage = "Add the {0} ya Schmuck";


        [Required(ErrorMessage = "Add the {0} ya Schmuck")]
        [Display(Name = "Person Name")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "{0} needs to be between {2}-{1} characters")]
        [RegularExpression("^[A-Za-z .]+$", ErrorMessage = "{0} needs to be in the format {1}")]
        public string? PersonName { get; set; }

        [Required(ErrorMessage = "Add the {0} ya Schmuck")]
        [EmailAddress(ErrorMessage = "{0} should be a valid email address")]
        public string? Email { get; set; }


        //[ValidateNever]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Add the {0} ya Schmuck")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Add the {0} ya Schmuck")]
        [Compare("Password", ErrorMessage = "{0} and {1} do not match")]
        [Display(Name ="Re-enter Password")]
        public string? ConfirmPassword { get; set; }

        [Range(0, 999.99, ErrorMessage = "{0} should be between ${1} and ${2}")]
        [RegularExpression("^[0-9]+.[0-9]?[0-9]?$")]
        public double? Price { get; set; }

        [MinimumYearValidator(1996, ErrorMessage = "Ya done Goofed the Date of Birth. Year min is {0}")]
        public DateTime? DateOfBirth { get; set; }

        public override string ToString()
        {
            return $"Person object - PersonName: {PersonName}, Email: {Email}, Phone: {Phone}, Password: {Password}, ConfirmPassword: {ConfirmPassword}, Price: { Price} ";
        }

    }
}
