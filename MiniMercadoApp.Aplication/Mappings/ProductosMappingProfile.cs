using AutoMapper;
using MinimercadoApp.Application.Requests;
using MiniMercadoApp.Application.Requests;
using MiniMercadoApp.Domain.Entities;

namespace MiniMercadoApp.Aplication.Mappings
{
    public class ProductosMappingProfile : Profile
    {
        public ProductosMappingProfile()
        {
            CreateMap<CreateProductosRequest, Productos>();
            CreateMap<Productos, CreateProductosRequest>();

            CreateMap<UpdateProductosRequest, Productos>();
            CreateMap<Productos, UpdateProductosRequest>();
        }
    }
}
