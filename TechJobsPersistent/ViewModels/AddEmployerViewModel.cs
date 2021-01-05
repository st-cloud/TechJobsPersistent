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

        //public AddEmployerViewModel(string name, string location)
        //{
        //    Name = name;
        //    Location = location;
        //}
        //do I need to add an empty constructor? > it added it for me. why?
    }
}
