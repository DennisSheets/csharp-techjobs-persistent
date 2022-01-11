using System.ComponentModel.DataAnnotations;

namespace TechJobsPersistent.ViewModels
{
    public class AddEmployerViewModel
    {
        [Required(ErrorMessage ="Name is Required")]
        [StringLength(30,MinimumLength =5)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Location is Required")]
        [StringLength(30, MinimumLength = 5)]
        public string Location { get; set; }

        public AddEmployerViewModel() { }
        public AddEmployerViewModel(string name, string location)
        {
            Name = name;
            Location = location;
        }

    }
}
