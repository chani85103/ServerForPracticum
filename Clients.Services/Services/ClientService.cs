using AutoMapper;
using Clients.Common.DTO_s;
using Clients.Repository.Entities;
using Clients.Repository.Interfaces;
using Clients.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clients.Services.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;

        private readonly IMapper _mapper;

        public ClientService(IClientRepository clientRepository, IMapper mapper)
        {
            _clientRepository = clientRepository;
            _mapper = mapper;
        }

        public async Task<Common.DTO_s.ClientDTO> AddAsync(Common.DTO_s.ClientDTO client)
        {
            List<Child> children;
            children = _mapper.Map<List<Child>>(client.Children);
            client.Children = null;
            Client c = _mapper.Map<Client>(client);
            c.Children = children;
            c = await _clientRepository.AddAsync(c);
            children = c.Children;
            c.Children = null;
            client = _mapper.Map<ClientDTO>(c);
            client.Children = _mapper.Map<List<ChildDTO>>(children);
            return client;
        }

        public async Task<List<Common.DTO_s.ClientDTO>> GetListAsync()
        {
            List<Client> clients = await _clientRepository.GetAllAsync();
            List<ClientDTO> result = new List<ClientDTO>();
            foreach (Client client in clients)
            {
                List<ChildDTO> children;
                children = _mapper.Map<List<ChildDTO>>(client.Children);
                client.Children = null;
                ClientDTO c = _mapper.Map<ClientDTO>(client);
                c.Children = children;
                result.Add(c);
            }
            return result;
        }

        public async Task<bool> IsExistsAsync(string idNumber)
        {
            return await _clientRepository.IsExistsAsync(idNumber);
        }



        public async Task<ClientDTO> GetByIdAsync(int id)
        {
            Client c = await _clientRepository.GetByIdAsync(id);
            List<ChildDTO> children = _mapper.Map<List<ChildDTO>>(c.Children);
            c.Children = null;
            ClientDTO client = _mapper.Map<ClientDTO>(c);
            client.Children = children;
            return client;

        }




        public async Task<List<ChildDTO>> UpdateAsync(string id, ChildDTO[] children)
        {
            Child[] c = _mapper.Map<Child[]>(children);
            List<Child> cn = await _clientRepository.UpdateAsync(id, c);
            return _mapper.Map<List<ChildDTO>>(cn);
        }

        public async Task<ClientDTO> GetByIdNumberAsync(string idNumber)
        {
            Client c = await _clientRepository.GetByIdNumberAsync(idNumber);
            List<ChildDTO> children = _mapper.Map<List<ChildDTO>>(c.Children);
            c.Children = null;
            ClientDTO client = _mapper.Map<ClientDTO>(c);
            client.Children = children;
            return client;
        }

        public async Task<ClientDTO> UpdateAsync(ClientDTO client)
        {
            List<Child> children;
            children = _mapper.Map<List<Child>>(client.Children);
            client.Children = null;
            Client c = _mapper.Map<Client>(client);
            c.Children = children;
            c = await _clientRepository.UpdateAsync(c);
            client = null;
            if (c != null)
            {
                children = c.Children;
                c.Children = null;
                client = _mapper.Map<ClientDTO>(c);
                client.Children = _mapper.Map<List<ChildDTO>>(children);
            }
            return client;
        }

        public async Task DeleteAsync(int id)
        {
            await _clientRepository.DeleteAsync(id);
        }
    }
}
