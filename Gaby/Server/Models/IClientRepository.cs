using System;
using Gaby.Shared.Data;
using Gaby.Shared.Model;

namespace Gaby.Server.Models
{
    public interface IClientRepository
    {
        PagedResult<MemberClient> GetClient(string? name, int page);
        Task<MemberClient?> GetClient(int clientId);
        Task<MemberClient> AddClient(MemberClient client);
        Task<MemberClient?> UpdateClient(MemberClient client);
        Task<MemberClient?> DeleteClient(int clientId);
    }
}

