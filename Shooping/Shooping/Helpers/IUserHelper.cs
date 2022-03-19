using Microsoft.AspNetCore.Identity;
using Shooping.Data.Entities;
using Shooping.Models;

namespace Shooping.Helpers
{
    public interface IUserHelper
    {
        Task<IdentityResult> AddUserAsync(User user, string password);
        Task<User> AddUserAsync(AddUserViewModel model);
        Task AddUserToRoleAsync(User user, string roleName);
        Task CheckRoleAsync(string roleName);
        Task<User> GetUserAsync(string email);
        Task<bool> IsUserInRoleAsync(User user, string roleName);
        Task<SignInResult> LoginAsync(LoginViewModel model);
        Task LogoutAsync();
    }
}