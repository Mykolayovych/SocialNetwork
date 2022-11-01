using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SocialNetwork.ViewModels
{
    public class EditUserViewModel
    {
        public string Id { get; set; }
        public string Email { get; set; }

        [Required]
        [Display(Name = "Логін")]
        [StringLength(20, MinimumLength = 1, ErrorMessage =
            "Довжина імені користувача повинна становити від 1 до 20 символів")]
        public string UserName { get; set; }

        [Display(Name = "Рік народження")]
        public int? Year { get; set; }

        [MaxLength(30, ErrorMessage =
            "Назва країни має містити до 30 символів")]
        [Display(Name = "Країна")]
        public string Country { get; set; }

        [MaxLength(30, ErrorMessage =
            "Назва міста має містити до 20 символів")]
        [Display(Name = "Місто")]
        public string City { get; set; }

        [MaxLength(40, ErrorMessage =
            "Назва компанії має містити до 40 символів")]
        [Display(Name = "Компанія")]
        public string Company { get; set; }

        [MaxLength(100, ErrorMessage =
            "Довжина статусу має бути до 100 символів")]
        [Display(Name = "Статус")]
        public string Status { get; set; }

        [Display(Name = "Зображення профілю")]
        public IFormFile ProfilePicture { get; set; }

        public IList<string> AuthenticatedUserRoles { get; set; }
        public string CurrentProfilePictureString { get; set; }
        public string CalledFromAction { get; set; }
    }
}
