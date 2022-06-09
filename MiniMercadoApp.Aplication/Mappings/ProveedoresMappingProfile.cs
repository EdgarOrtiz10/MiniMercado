using AutoMapper;
using MinimercadoApp.Application.Requests;
using MiniMercadoApp.Application.Requests;
using MiniMercadoApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMercadoApp.Aplication.Mappings
{
    public class ProveedoresMappingProfile : Profile
    {
        public ProveedoresMappingProfile()
        {
            CreateMap<CreateProveedoresRequest, Proveedores>();
            CreateMap<Proveedores, CreateProveedoresRequest>();

            CreateMap<UpdateProveedoresRequest, Proveedores>();
            CreateMap<Proveedores, UpdateProveedoresRequest>();
        }
    }
}
