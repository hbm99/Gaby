using System;
using Gaby.Server.Models;
using Gaby.Shared.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Gaby.Server.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class ClientController : ControllerBase
    {
        private readonly IClientRepository _clientRepository;

        public ClientController(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        
        [AllowAnonymous]
        [HttpGet]
        public ActionResult GetClient([FromQuery] string? name, int page)
        {
            return Ok(_clientRepository.GetClient(name, page));
        }

        
        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<ActionResult> GetClient(int id)
        {
            return Ok(await _clientRepository.GetClient(id));
        }

        
        [HttpPost]
        public async Task<ActionResult> AddClient(MemberClient client)
        {
            return Ok(await _clientRepository.AddClient(client));
        }

        
        [HttpPut]
        public async Task<ActionResult> UpdateClient(MemberClient client)
        {
            return Ok(await _clientRepository.UpdateClient(client));
        }

        
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteClient(int id)
        {
            return Ok(await _clientRepository.DeleteClient(id));
        }
    }
}

