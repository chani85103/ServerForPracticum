using Clients.Repository.Entities;
using Clients.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Clients.Repository.Repositories
{
    public class ClientRepository : IClientRepository
    {

        private readonly IContext _context;

        public ClientRepository(IContext context)
        {
            this._context = context;
        }

        public async Task<Client> AddAsync(Client client)
        {
            var nClient = new Client
            {
                Id = client.Id,
                FirstName = client.FirstName,
                LastName = client.LastName,
                BirthDate = client.BirthDate,
                ToAdvertise= client.ToAdvertise,
                MyImpression = client.MyImpression,
                HmoId= client.HmoId,
                EGender= client.EGender
            };
            var added= await _context.Clients.AddAsync(nClient);
            await _context.SaveChangesAsync();
            return added.Entity;
        }

        public async Task DeleteAsync(string id)
        {
            _context.Clients.Remove(await GetByIdAsync(id));
            await _context.SaveChangesAsync();
        }

        public async Task<List<Client>> GetAllAsync()
        {
            return await _context.Clients.ToListAsync();
        }

        public async Task<Client> GetByIdAsync(string Id)
        {
            return await _context.Clients.FindAsync(Id);
        }

        public async Task<bool> IsExistsAsync(string id)
        {
            return await _context.Clients.AnyAsync(e => e.Id == id);
        }

        public async Task<List<Child>> UpdateAsync(string id,Child[] children)
        {
            var c = await _context.Clients.FindAsync(id);
            if (c != null)
            {
                c.Children = children.ToList();
                await _context.SaveChangesAsync();
            }
           
            return c?.Children;
        }
    }
}

