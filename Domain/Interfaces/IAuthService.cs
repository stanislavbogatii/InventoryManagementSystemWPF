using Domain.Entities;
using Domain.Enums;

namespace Domain.Interfaces
{
    public interface IAuthService
    {
        Task<User?> LoginAsync(string username, string password);
        Task<bool> RegisterAsync(string username, string password, UserRole role);
    }
}
