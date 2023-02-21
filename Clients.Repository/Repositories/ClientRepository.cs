using Clients.Repository.Entities;
using Clients.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Cryptography;
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
            var added = _context.Clients.Add(client);
            await _context.SaveChangesAsync();
            return await GetByIdAsync(added.Entity.Id);
        }
        public async Task DeleteAsync(int id)
        {
            _context.Clients.Remove(await GetByIdAsync(id));
            await _context.SaveChangesAsync();
        }

        public async Task<List<Client>> GetAllAsync()
        {
            return await _context.Clients.Include(x => x.HMO).ToListAsync();
        }


        public async Task<Client> GetByIdAsync(int id)
        {
            return await (_context.Clients.Include(x => x.HMO)).FirstOrDefaultAsync(x=>x.Id==id);
        }

        public async Task<Client> GetByIdNumberAsync(string idNumber)
        {
            
            return await _context.Clients.FirstOrDefaultAsync(x=>x.IdNumber==idNumber);
        }

        public async Task<bool> IsExistsAsync(string idNumber)
        {
            return await _context.Clients.AnyAsync(e => e.IdNumber == idNumber);
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

        public async Task<Client> UpdateAsync( Client client)
        {
            var x = await _context.Clients.FindAsync(client.Id);
            if (x != null)
            {
                x.IdNumber = client.IdNumber;
                x.FirstName = client.FirstName;
                x.LastName = client.LastName;
                x.BirthDate = client.BirthDate;
                x.ToAdvertise = client.ToAdvertise;
                x.MyImpression = client.MyImpression;
                x.HmoId = client.HmoId;
                x.EGender = client.EGender;
            }
            await _context.SaveChangesAsync();
            return x;
        }
    }
}

