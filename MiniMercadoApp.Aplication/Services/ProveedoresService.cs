using AutoMapper;
using MinimercadoApp.Application.Requests;
using MinimercadoApp.Domain.Interfaces;
using MiniMercadoApp.Aplication.Interface;
using MiniMercadoApp.Aplication.Response;
using MiniMercadoApp.Application.Requests;
using MiniMercadoApp.Domain.Entities;

namespace MiniMercadoApp.Aplication.Services
{
    public class ProveedoresService : IProveedoresService
    {
        private readonly IProveedoresRepository _repository;
        private readonly IMapper _mapper;

        public ProveedoresService(IProveedoresRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void DeleteProveedores(int IdProveedor)
        {
            _repository.DeleteProveedores(IdProveedor);
        }

        public IEnumerable<ProveedoresResponse> GetProveedores()
        {
            var proveedores = _repository.GetProveedores();
            var proveedoresResponse = _mapper.Map<IEnumerable<ProveedoresResponse>>(proveedores);
            return proveedoresResponse;
        }

        public ProveedoresResponse GetProveedoresById(int IdProveedores)
        {
            // Convertimos de 
            var proveedores = _repository.GetProveedoresById(IdProveedores);
            var proveedoresResponse = _mapper.Map<ProveedoresResponse>(proveedores);
            return proveedoresResponse;
        }

        public void InsertProveedores(CreateProveedoresRequest request)
        {
            var proveedores = _mapper.Map<Proveedores>(request);
            _repository.InsertProveedores(proveedores);
        }

        public void UpdateProveedores(UpdateProveedoresRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
