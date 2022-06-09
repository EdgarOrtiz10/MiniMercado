using AutoMapper;
using MinimercadoApp.Application.Requests;
using MiniMercadoApp.Application.Requests;
using MiniMercadoApp.Domain.Entities;

namespace MiniMercadoApp.Aplication.Mappings
{
    public class FacturasMappingProfile : Profile
    {
        public FacturasMappingProfile()
        {
            CreateMap<CreateFacturasRequest, Factura>();
            CreateMap<Factura, CreateFacturasRequest>();

            CreateMap<UpdateFacturasRequest, Factura>();
            CreateMap<Factura, UpdateFacturasRequest>();
        }
    }
}
