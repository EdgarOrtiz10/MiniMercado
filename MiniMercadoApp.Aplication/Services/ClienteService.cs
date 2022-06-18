using AutoMapper;
using MinimercadoApp.Application.Requests;
using MinimercadoApp.Domain.Interfaces;
using MiniMercadoApp.Aplication.Interface;
using MiniMercadoApp.Aplication.Response;
using MiniMercadoApp.Application.Requests;
using MiniMercadoApp.Domain.Entities;

namespace MiniMercadoApp.Aplication.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _repository;
        private readonly IMapper _mapper;

        public ClienteService(IClienteRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void DeleteCliente(int IdCliente)
        {
            _repository.DeleteCliente(IdCliente);
        }

        public IEnumerable<ClienteResponse> GetCliente()
        {
            var cliente = _repository.GetCliente();
            var clienteResponse = _mapper.Map<IEnumerable<ClienteResponse>>(cliente);
            return clienteResponse;
        }

        public ClienteResponse GetClienteById(int IdCliente)
        {
            // Convertimos de 
            var cliente = _repository.GetClienteById(IdCliente);
            var clienteResponse = _mapper.Map<ClienteResponse>(cliente);
            return clienteResponse;
        }

        public void InsertCliente(CreateClienteRequest request)
        {
            var cliente = _mapper.Map<Cliente>(request);
            _repository.InsertCliente(cliente);
        }

        public void UpdateCliente(UpdateClienteRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
