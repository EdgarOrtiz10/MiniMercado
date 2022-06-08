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
            CreateMap<CreateFacturasRequest, TblFactura>();
            CreateMap<TblFactura, CreateFacturasRequest>();

            CreateMap<UpdateFacturasRequest, TblFactura>();
            CreateMap<TblFactura, UpdateFacturasRequest>();
        }
    }
}
