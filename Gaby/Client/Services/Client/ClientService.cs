using System;
using Gaby.Shared.Data;
using Gaby.Shared.Model;

namespace Gaby.Client.Services.Client
{
    public class ClientService : IClientService
    {
        private IHttpService _httpService;

        public ClientService(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<PagedResult<MemberClient>> GetClient(string? name, string page)
        {
            return await _httpService.Get<PagedResult<MemberClient>>("api/client" + "?page=" + page + "&name=" + name);
        }

        public async Task<MemberClient> GetClient(int id)
        {
            return await _httpService.Get<MemberClient>($"api/client/{id}");
        }

        public async Task DeleteClient(int id)
        {
            await _httpService.Delete($"api/client/{id}");
        }

        public async Task AddClient(MemberClient client)
        {
            await _httpService.Post($"api/client", client);
        }

        public async Task UpdateClient(MemberClient client)
        {
            await _httpService.Put($"api/client", client);
        }
    }
}

