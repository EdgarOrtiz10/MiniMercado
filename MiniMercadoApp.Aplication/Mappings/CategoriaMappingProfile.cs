using AutoMapper;
using MinimercadoApp.Application.Requests;
using MiniMercadoApp.Aplication.Response;
using MiniMercadoApp.Application.Requests;
using MiniMercadoApp.Domain.Entities;

namespace MiniMercadoApp.Aplication.Mappings
{
    public class CategoriaMappingProfile : Profile
    {
        public CategoriaMappingProfile()
        {
            CreateMap<CreateCategoriaRequest, Categoria>();
            CreateMap<Categoria, CreateCategoriaRequest>();

            CreateMap<UpdateCategoriaRequest, Categoria>();
            CreateMap<Categoria, UpdateCategoriaRequest>();

            CreateMap<Categoria, CategoriaResponse>();
        }
    }
}
