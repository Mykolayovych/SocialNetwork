using System.Collections.Generic;
using SocialNetwork.Models;

namespace SocialNetwork.ViewModels
{
    public class UserRelationsViewModel
    {
        public string UserName { get; set; }
        public IEnumerable<User> RelatedUsers { get; set; }
    }
}
