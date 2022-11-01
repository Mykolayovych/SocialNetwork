﻿using System.Collections.Generic;
using SocialNetwork.Models;

namespace SocialNetwork.ViewModels
{
    public class FeedPageViewModel
    {
        public User AuthenticatedUser { get; set; }
        public PageViewModel PageViewModel { get; set; }
        public IEnumerable<Post> Posts { get; set; }
    }
}
