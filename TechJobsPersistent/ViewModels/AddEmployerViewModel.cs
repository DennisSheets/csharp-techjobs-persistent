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

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
