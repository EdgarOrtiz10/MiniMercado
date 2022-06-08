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
            CreateMap<CreateClienteRequest, TblCliente>();
            CreateMap<TblCliente, CreateClienteRequest>();

            CreateMap<UpdateClienteRequest, TblCliente>();
            CreateMap<TblCliente, UpdateClienteRequest>();
        }
    }
}
