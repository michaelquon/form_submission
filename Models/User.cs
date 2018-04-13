using System.ComponentModel.DataAnnotations;

namespace form.Models
{
    public class User
    {
        [Display(Name = "First Name")]
        [Required]
        [MinLength(4, ErrorMessage="First name must be more than 4 characters long")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        [Required]
        [MinLength(4, ErrorMessage="Last name must be more than 4 characters long")]
        public string LastName { get; set; }
        [Display(Name = "Age")]
        [Required]
        [Range(1,200, ErrorMessage="Age must be a positive number")]
        public int Age { get; set; }
        [Display(Name = "Email")]
        [Required]
        [EmailAddress()]
        public string Email { get; set; }
        [Display(Name ="Password")]
        [Required]
        [MinLength(8, ErrorMessage="Password must be more than 8 characters long")]
        public string Password { get; set; }
    }
}