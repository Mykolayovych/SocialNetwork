using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using SocialNetwork.Models;
using SocialNetwork.ViewModels;
using SocialNetwork.Interfaces;

namespace SocialNetwork.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeControllable _repository;

        public HomeController(IHomeControllable repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> Index(int page = 1)
        {
            const int PAGE_SIZE = 5;
            IEnumerable<Post> allPosts = _repository.GetAllPosts().OrderByDescending(post => post.PostedTime);
            IEnumerable<Post> currentPagePosts = allPosts.Skip((page - 1) * PAGE_SIZE).Take(PAGE_SIZE);
            User authenticatedUser = null;

            if (User.Identity.IsAuthenticated)
            {
                authenticatedUser = await _repository.FindByNameAsync(User.Identity.Name);
            }

            HomepageViewModel model = new HomepageViewModel()
            {
                AuthenticatedUser = authenticatedUser,
                PageViewModel = new PageViewModel(page, allPosts.Count(), PAGE_SIZE),
                Posts = currentPagePosts,
                AuthenticatedUserRoles = authenticatedUser != null
                    ? await _repository.GetRolesAsync(authenticatedUser)
                    : new List<string> { "user" }
            };

            _repository.LogInformation("On Home page");
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Feed(int page = 1)
        {
            const int PAGE_SIZE = 5;
            User authenticatedUser = null;

            if (User.Identity.IsAuthenticated)
            {
                authenticatedUser = await _repository.FindByNameAsync(User.Identity.Name);
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }

            List<Post> followedUsersPosts = new List<Post>();

            foreach (Following following in _repository.GetAllFollowings())
            {
                if (following.ReaderId == authenticatedUser.Id)
                {
                    followedUsersPosts.AddRange(following.FollowedUser.Posts);
                }
            }

            IEnumerable<Post> currentPagePosts = followedUsersPosts
                .OrderByDescending(post => post.PostedTime).Skip((page - 1) * PAGE_SIZE).Take(PAGE_SIZE);

            FeedPageViewModel model = new FeedPageViewModel()
            {
                AuthenticatedUser = authenticatedUser,
                PageViewModel = new PageViewModel(page, followedUsersPosts.Count(), PAGE_SIZE),
                Posts = currentPagePosts
            };

            _repository.LogInformation("On Feed page");
            return View(model);
        }
    }
}
