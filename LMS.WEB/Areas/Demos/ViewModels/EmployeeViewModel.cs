using System;
using System.ComponentModel.DataAnnotations;

namespace LMS.WEB.Areas.Demos.ViewModels
{
    public class EmployeeViewModel
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} cannot be empty")]
        [MaxLength(80, ErrorMessage = "{0} can contain max of {1} characters")]
        [MinLength(2, ErrorMessage ="{0} should contain atleast of {1} characters")]
        public string EmployeeName { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Range(minimum: 0, maximum:300000, ErrorMessage ="{0} has to be between {1} and {2}")]
        public decimal Salary { get; set; }

        public bool IsEnabled { get; set; }
    }
}
