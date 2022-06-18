using MiniMercadoApp.Domain.Entities;

namespace MinimercadoApp.Domain.Interfaces
{
    public interface IClienteRepository
    {
        Cliente GetClienteById(int IdCliente);
        IEnumerable<Cliente> GetCliente();

        void InsertCliente(Cliente cliente);

        void UpdateCliente(Cliente cliente);

        void DeleteCliente(int IdCliente);
    }
}
