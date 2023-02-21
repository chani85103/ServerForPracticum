using AutoMapper;
using Clients.Common.DTO_s;
using Clients.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clients.Services
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Client, ClientDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ReverseMap();
            CreateMap<HMO, HmoDTO>()
          //.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Name))
          .ReverseMap();
            CreateMap<Child, ChildDTO>()
          .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.FirstName))
          .ReverseMap();
        }
    }
}
