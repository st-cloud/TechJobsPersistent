using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
        [Required(ErrorMessage = "Please enter a job name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please select an employer.")]
        public int EmployerId { get; set; }

        public List<SelectListItem> Employers { get; set; }

        public List<Skill> Skills { get; set; }

        public AddJobViewModel()
        {
        }
        //no args constructor necessary?

        public AddJobViewModel(List<Employer> submittedEmployers, List<Skill> submittedSkills)
        {
            Employers = new List<SelectListItem>();

            Skills = submittedSkills;

            foreach (var employer in submittedEmployers)
            {
                Employers.Add(new SelectListItem
                {
                    Value = employer.Id.ToString(),
                    Text = employer.Name
                });
            }
        }
    }
}
