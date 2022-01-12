using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
        [Required(ErrorMessage ="Job Name is required")]
        [StringLength(30,MinimumLength =5,ErrorMessage ="Job Name must be between 5 and 30 characters")]
        public string Name { get; set; }
        public int EmployerId { get; set; }

        public List<SelectListItem> Employers { get; set; }
        public List<SelectListItem> Skills { get; set; }
        public AddJobViewModel() { }
        public AddJobViewModel(List<Employer> employers, List<Skill> skills)
        {

            Employers = new List<SelectListItem>();

            foreach(var employer in employers)
            {
                Employers.Add(new SelectListItem
                {
                    Value = employer.Id.ToString(),
                    Text = employer.Name,
                });
            }

            Skills = new List<SelectListItem>();

            foreach (var skill in skills)
            {
                Skills.Add(new SelectListItem
                {
                    Value = skill.Id.ToString(),
                    Text = skill.Name,
                });
            }
    

        }
    }
}
