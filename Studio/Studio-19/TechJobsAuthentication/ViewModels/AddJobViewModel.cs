using System;
using System.ComponentModel.DataAnnotations;

namespace TechJobsAuthentication.ViewModels
{
    public class AddJobViewModel
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters in length")]
        public string Name { get; set; }

        public string Employer { get; set; }

        public string Skill { get; set; }
    }
}
