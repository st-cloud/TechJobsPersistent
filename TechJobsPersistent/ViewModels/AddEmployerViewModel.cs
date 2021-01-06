using System;
using System.ComponentModel.DataAnnotations;

namespace TechJobsPersistent.ViewModels
{
    public class AddEmployerViewModel
    {
        [Required(ErrorMessage = "Please enter an employer name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter an employer location.")]
        public string Location { get; set; }

        public AddEmployerViewModel()
        {
        }
    }
}
