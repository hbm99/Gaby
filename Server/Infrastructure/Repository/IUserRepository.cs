using System;
using Gaby.Server.Authorization;
using Gaby.Shared.Pager;
using Gaby.Shared.Model;

namespace Gaby.Server.Infrastructure.Repository
{
    public interface IUserRepository
    {
        AuthenticateResponse Authenticate(AuthenticateRequest request);
        PagedResult<User> GetUsers(string? name, int page);
        Task<User?> GetUser(int Id);
        Task<User> AddUser(User user);
        Task<User?> UpdateUser(User user);
        Task<User?> DeleteUser(int id);
    }
}

