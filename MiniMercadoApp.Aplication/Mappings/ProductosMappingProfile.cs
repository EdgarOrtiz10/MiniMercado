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
            CreateMap<CreateProductosRequest, TblProducto>();
            CreateMap<TblProducto, CreateProductosRequest>();

            CreateMap<UpdateProductosRequest, TblProducto>();
            CreateMap<TblProducto, UpdateProductosRequest>();
        }
    }
}
