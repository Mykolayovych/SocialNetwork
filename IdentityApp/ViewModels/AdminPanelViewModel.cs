using SocialNetwork.Models;

namespace SocialNetwork.ViewModels
{
    public class AdminPanelViewModel
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public int? Year { get; set; }
        public string Country { get; set; }
        public int Page { get; set; } = 1;
        public SortState SortOrder { get; set; } 

        public AdminPanelViewModel()
        {
            SortOrder = SortState.NameAscending;
        }
    }
}
