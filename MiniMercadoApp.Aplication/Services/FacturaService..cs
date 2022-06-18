using AutoMapper;
using MinimercadoApp.Application.Requests;
using MinimercadoApp.Domain.Interfaces;
using MiniMercadoApp.Aplication.Interface;
using MiniMercadoApp.Aplication.Response;
using MiniMercadoApp.Application.Requests;
using MiniMercadoApp.Domain.Entities;

namespace MiniMercadoApp.Aplication.Services
{
    public class FacturaService : IFacturaService
    {
        private readonly IFacturasRepository _repository;
        private readonly IMapper _mapper;

        public FacturaService(IFacturasRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void DeleteFactura(int IdFactura)
        {
            _repository.DeleteFactura(IdFactura);
        }

        public IEnumerable<FacturaResponse> GetFactura()
        {
            var factura = _repository.GetFactura();
            var facturaResponse = _mapper.Map<IEnumerable<FacturaResponse>>(factura);
            return facturaResponse;
        }

        public FacturaResponse GetFacturaById(int IdFactura)
        {
            // Convertimos de 
            var factura = _repository.GetFacturaById(IdFactura);
            var facturaResponse = _mapper.Map<FacturaResponse>(factura);
            return facturaResponse;
        }

        public void InsertFactura(CreateFacturasRequest request)
        {
            var factura = _mapper.Map<Factura>(request);
            _repository.InsertFactura(factura);
        }

        public void UpdateFactura(UpdateFacturasRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
