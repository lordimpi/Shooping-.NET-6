using Microsoft.AspNetCore.Identity;
using Shooping.Data.Entities;

namespace Shooping.Helpers
{
    public interface IUserHelper
    {
        Task<IdentityResult> AddUserAsync(User user, string password);
        Task AddUserToRoleAsync(User user, string roleName);
        Task CheckRoleAsync(string roleName);
        Task<User> GetUserAsync(string email);
        Task<bool> IsUserInRoleAsync(User user, string roleName);
    }
}