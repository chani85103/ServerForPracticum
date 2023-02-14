using Clients.Repository.Entities;
using Clients.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clients.Repository.Repositories
{
    public class HmoRepository : IHmoRepository
    {
        private readonly IContext _context;

        public HmoRepository(IContext context)
        {
            _context = context;
        }

        public async Task<HMO> AddAsync( string name)
        {
            var added = _context.HMOs.Add(new HMO( name));
            await _context.SaveChangesAsync();
            return added.Entity;
        }


        public async Task DeleteAsync(int id)
        {
            _context.HMOs.Remove(await GetByIdAsync(id));
            await _context.SaveChangesAsync();
        }


        public async Task<List<HMO>> GetAllAsync()
        {
            return await _context.HMOs.ToListAsync();
        }


        public async Task<HMO> GetByIdAsync(int Id)
        {

            return await _context.HMOs.FindAsync(Id);
        }

        public async Task<HMO> UpdateAsync(HMO h)
        {
            var x = await _context.HMOs.FindAsync(h.Id);
            if (x != null)
            {
                x.Name = h.Name;
            }
            await _context.SaveChangesAsync();
            return h;
        }
    }
}

