using System.ComponentModel.DataAnnotations;

namespace SocialNetwork.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Логін")]
        [StringLength(20, MinimumLength = 1, ErrorMessage = 
            "The username must be between 1 and 20 symbols long")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = 
            "The password must be between 6 and 20 symbols long")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Підтвердіть пароль")]
        [Compare("Password", ErrorMessage = "The passwords do not match")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = 
            "The password must be between 6 and 20 symbols long")]
        public string ConfirmPassword { get; set; }
    }
}
