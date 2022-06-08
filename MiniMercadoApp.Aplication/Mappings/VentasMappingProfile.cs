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
    public class VentasMappingProfile : Profile
    {
        public VentasMappingProfile()
        {
            CreateMap<CreateVentasRequest, TblVenta>();
            CreateMap<TblVenta, CreateVentasRequest>();

            CreateMap<UpdateVentasRequest, TblVenta>();
            CreateMap<TblVenta, UpdateVentasRequest>();
        }
    }
}
