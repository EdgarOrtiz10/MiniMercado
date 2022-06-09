using AutoMapper;
using MinimercadoApp.Application.Requests;
using MiniMercadoApp.Application.Requests;
using MiniMercadoApp.Domain.Entities;

namespace MiniMercadoApp.Aplication.Mappings
{
    public class ClienteMappingProfile : Profile
    {
        public ClienteMappingProfile()
        {
            CreateMap<CreateClienteRequest, Cliente>();
            CreateMap<Cliente, CreateClienteRequest>();

            CreateMap<UpdateClienteRequest, Cliente>();
            CreateMap<Cliente, UpdateClienteRequest>();
        }
    }
}
