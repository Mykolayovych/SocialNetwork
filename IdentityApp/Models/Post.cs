using System;
using System.Collections.Generic;

namespace SocialNetwork.Models
{
    public class Post
    {
        public string Id { get; set; }
        public string Content { get; set; }
        public DateTime PostedTime { get; set; }
        public int Likes { get; set; }
        public bool IsEdited { get; set; }
        public virtual List<PostPicture> PostPictures { get; set; } 
        public virtual List<LikedPost> LikedPosts { get; set; } 

        public string UserId { get; set; }
        public virtual User User { get; set; }

        public Post()
        {
            PostPictures = new List<PostPicture>();
            LikedPosts = new List<LikedPost>();
        }
    }
}
