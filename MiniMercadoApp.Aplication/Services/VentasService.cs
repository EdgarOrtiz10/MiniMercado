using AutoMapper;
using MinimercadoApp.Application.Requests;
using MinimercadoApp.Domain.Interfaces;
using MiniMercadoApp.Aplication.Interface;
using MiniMercadoApp.Aplication.Response;
using MiniMercadoApp.Application.Requests;
using MiniMercadoApp.Domain.Entities;

namespace MiniMercadoApp.Aplication.Services
{
    public class VentasService : IVentasService
    {
        private readonly IVentasRepository _repository;
        private readonly IMapper _mapper;

        public VentasService(IVentasRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void DeleteVentas(int IdProveedor)
        {
            _repository.DeleteVentas(IdProveedor);
        }

        public IEnumerable<VentasResponse> GetVentas()
        {
            var ventas = _repository.GetVentas();
            var ventasResponse = _mapper.Map<IEnumerable<VentasResponse>>(ventas);
            return ventasResponse;
        }

        public VentasResponse GetVentasById(int IdVentas)
        {
            // Convertimos de 
            var ventas = _repository.GetVentasById(IdVentas);
            var ventasResponse = _mapper.Map<VentasResponse>(ventas);
            return ventasResponse;
        }

        public void InsertVentas(CreateVentasRequest request)
        {
            var ventas = _mapper.Map<Ventas>(request);
            _repository.InsertVentas(ventas);
        }

        public void UpdateVentas(UpdateVentasRequest request)
        {
            var venta = _mapper.Map<Ventas>(request);
            _repository.UpdateVentas(venta);
        }
    }
}
