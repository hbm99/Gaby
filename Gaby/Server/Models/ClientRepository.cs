using System;
using Gaby.Server.Infrastructure;
using Gaby.Shared.Data;
using Gaby.Shared.Model;
using Microsoft.EntityFrameworkCore;

namespace Gaby.Server.Models
{
    public class ClientRepository : IClientRepository
    {
        private readonly GabyDbContext _appDbContext;

        public ClientRepository(GabyDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<MemberClient> AddClient(MemberClient client)
        {
            var result = await _appDbContext.MemberClients.AddAsync(client);
            await _appDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<MemberClient?> DeleteClient(int clientId)
        {
            var result = await _appDbContext.MemberClients.FirstOrDefaultAsync(p => p.ClientId == clientId);
            if (result != null)
            {
                _appDbContext.MemberClients.Remove(result);
                await _appDbContext.SaveChangesAsync();
            }
            else
            {
                throw new KeyNotFoundException("Client not found");
            }
            return result;
        }

        public async Task<MemberClient?> GetClient(int clientId)
        {
            var result = await _appDbContext.MemberClients
                //.Include(p => p.Offers)
                .FirstOrDefaultAsync(p => p.ClientId == clientId);
            if (result != null)
            {
                return result;
            }
            else
            {
                throw new KeyNotFoundException("Client not found");
            }
        }

        public PagedResult<MemberClient> GetClient(string? name, int page)
        {
            int pageSize = 5;

            if (name != null)
            {
                return _appDbContext.MemberClients
                    .Where(p => p.Name.Contains(name, StringComparison.CurrentCultureIgnoreCase))
                    .OrderBy(p => p.ClientId)
                    //.Include(p => p.Offers)
                    .GetPaged(page, pageSize);
            }
            else
            {
                return _appDbContext.MemberClients
                    .OrderBy(p => p.ClientId)
                    //.Include(p => p.Offers)
                    .GetPaged(page, pageSize);
            }
        }

        public async Task<MemberClient?> UpdateClient(MemberClient client)
        {
            var result = await _appDbContext.MemberClients
                //.Include("Ofertas")
                .FirstOrDefaultAsync(p => p.ClientId == client.ClientId);
            if (result != null)
            {
                // Update existing client
                _appDbContext.Entry(result).CurrentValues.SetValues(client);

                //// Remove deleted offers
                //foreach (var existingOffer in result.Offers.ToList())
                //{
                //    if (!client.Offers.Any(o => o.OfferId == existingOffer.OfferId))
                //        _appDbContext.Offers.Remove(existingOffer);
                //}

                //// Update and Insert Offers
                //foreach (var offerModel in client.Offers)
                //{
                //    var existingOffer = result.Offers
                //        .Where(a => a.OfferId == offerModel.OfferId)
                //        .SingleOrDefault();
                //    if (existingOffer != null)
                //        _appDbContext.Entry(existingOffer).CurrentValues.SetValues(offerModel);
                //    else
                //    {
                //        var newOffer = new Offer
                //        {
                //            OfferId = offerModel.OfferId,
                //            Price = offerModel.Price,
                //            Availability = offerModel.Availability
                //        };
                //        result.Offers.Add(newOffer);
                //    }
                //}
                await _appDbContext.SaveChangesAsync();
            }
            else
            {
                throw new KeyNotFoundException("Client not found");
            }
            return result;
        }
    }
}

