﻿using System;
using Gaby.Shared.Data;
using Gaby.Shared.Model;

namespace Gaby.Client.Services.Client
{
	public interface IClientService
	{
        Task<PagedResult<MemberClient>> GetClient(string? name, string page);
        Task<MemberClient> GetClient(int id);

        Task DeleteClient(int id);

        Task AddClient(MemberClient person);

        Task UpdateClient(MemberClient person);
    }
}

