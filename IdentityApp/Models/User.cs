using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SocialNetwork.Models
{
    public class User : IdentityUser
    {
        [Display(Name = "Рік")]
        public int? Year { get; set; }
        [Display(Name = "Країна")]
        public string Country { get; set; }
        [Display(Name = "Місто")]
        public string City { get; set; }
        [Display(Name = "Компанія")]
        public string Company { get; set; }
        [Display(Name = "Статус")]
        public string Status { get; set; }
        [Display(Name = "Зображення профілю")]
        public byte[] ProfilePicture { get; set; }
        public int ReadersCount { get; set; }
        public int FollowsCount { get; set; }
        public virtual List<Post> Posts { get; set; } 
        public virtual List<LikedPost> LikedPosts { get; set; }
        public virtual List<Following> FollowingUsers { get; set; }
        public virtual List<Following> Followers { get; set; }

        public User()
        {
            Posts = new List<Post>();
            LikedPosts = new List<LikedPost>();
            FollowingUsers = new List<Following>();
            Followers = new List<Following>();

        }
    }
}