using MinimercadoApp.Application.Requests;
using MiniMercadoApp.Aplication.Response;
using MiniMercadoApp.Application.Requests;
using MiniMercadoApp.Domain.Entities;

namespace MiniMercadoApp.Aplication.Interface
{
    public interface IClienteService
    {
        ClienteResponse GetClienteById(int IdCliente);
        IEnumerable<ClienteResponse> GetCliente();

        void InsertCliente(CreateClienteRequest cliente);

        void UpdateCliente(UpdateClienteRequest cliente);

        void DeleteCliente(int IdCliente);
    }
}
