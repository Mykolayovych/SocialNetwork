using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Threading.Tasks;
using System.Linq.Expressions;
using SocialNetwork.Models;

namespace SocialNetwork.Interfaces
{
    public interface IPostPictureControllable
    {
        Task<PostPicture> FirstOrDefaultAsync(Expression<Func<PostPicture, bool>> predicate);
        Task<int> SaveChangesAsync();
        EntityEntry<PostPicture> Remove(PostPicture postPicture);
        void LogInformation(string message);
    }
}
