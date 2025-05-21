using Domain.Entities;
using Domain.Enums;
using Domain.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using BCrypt.Net;

namespace Infrastructure.Services
{
    public class AuthService : IAuthService
    {
        private readonly AppDbContext _db;
        public AuthService(AppDbContext db) => _db = db;

        public async Task<User?> LoginAsync(string username, string password)
        {
            var user = await _db.Users.FirstOrDefaultAsync(u => u.Username == username);
            if (user == null) return null;

            return VerifyPassword(password, user.PasswordHash) ? user : null;
        }

        public async Task<bool> RegisterAsync(string username, string password, UserRole role)
        {
            if (await _db.Users.AnyAsync(u => u.Username == username)) return false;

            var hash = BCrypt.Net.BCrypt.HashPassword(password);
            var user = new User { Username = username, PasswordHash = hash, Role = role };
            _db.Users.Add(user);
            await _db.SaveChangesAsync();
            return true;
        }

        private bool VerifyPassword(string password, string hash) =>
            BCrypt.Net.BCrypt.Verify(password, hash);
    }
}
