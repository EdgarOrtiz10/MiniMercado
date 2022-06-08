using AutoMapper;
using MinimercadoApp.Application.Requests;
using MiniMercadoApp.Application.Requests;
using MiniMercadoApp.Domain.Entities;

namespace MiniMercadoApp.Aplication.Mappings
{
    public class CategoriaMappingProfile : Profile
    {
        public CategoriaMappingProfile()
        {
            CreateMap<CreateCategoriaRequest, TblCategoria>();
            CreateMap<TblCategoria, CreateCategoriaRequest>();

            CreateMap<UpdateCategoriaRequest, TblCategoria>();
            CreateMap<TblCategoria, UpdateCategoriaRequest>();
        }
    }
}
