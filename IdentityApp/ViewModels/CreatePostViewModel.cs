using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using SocialNetwork.Models;

namespace SocialNetwork.ViewModels
{
    public class CreatePostViewModel
    {
        public string Id { get; set; }

        [MaxLength(350)]
        [Display(Name = "Контент")]
        public string Content { get; set; }

        public DateTime PostedTime { get; set; }
        public IFormFileCollection PostPictures { get; set; }
        public User User { get; set; }
    }
}
