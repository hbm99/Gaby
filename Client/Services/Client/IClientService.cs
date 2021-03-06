using System;
using Gaby.Shared.Pager;
using Gaby.Shared.Model;

namespace Gaby.Client.Services.Client
{
	public interface IClientService
	{
        Task<PagedResult<MemberClient>> GetClients(string? name, string page);
        Task<MemberClient> GetClient(int id);

        Task DeleteClient(MemberClient client);

        Task AddClient(MemberClient person);
        Task AddClientRange(IEnumerable<MemberClient> members);
        Task UpdateClient(MemberClient person);
    }
}

