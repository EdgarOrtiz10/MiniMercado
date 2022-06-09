using MinimercadoApp.Domain.Interfaces;
using MiniMercadoApp.Domain.Entities;
using MiniMercadoApp.Infrastructure.Persistance;

namespace MiniMercadoApp.Infrastructure.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private MiniMercadoContext _context;
        public ClienteRepository(MiniMercadoContext context)
        {
            _context = context;
        }

        public IEnumerable<Cliente> GetCliente()
        {
            return _context.Cliente;
        }

        public Cliente GetClienteById(int IdCliente)
        {
            return _context.Cliente.FirstOrDefault(x => x.IdCliente == IdCliente);
        }

        public void InsertCliente(Cliente cliente)
        {
            _context.Cliente.Add(cliente);
            _context.SaveChanges();
        }

        public void UpdateCliente(Cliente cliente)
        {
            var clienteExistente = _context.Cliente.FirstOrDefault(x => x.IdCliente == cliente.IdCliente);
            clienteExistente.Nombre1 = cliente.Nombre1;
            clienteExistente.Nombre2 = cliente.Nombre2;
            clienteExistente.Apellido1 = cliente.Apellido1;
            clienteExistente.Apellido2 = cliente.Apellido2;
            clienteExistente.Direccion = cliente.Direccion;
            clienteExistente.Telefono = cliente.Telefono;
            clienteExistente.Sexo = cliente.Sexo;
            clienteExistente.Correo = cliente.Correo;
            _context.SaveChanges();
        }

        public void DeleteCliente(int IdCliente)
        {
            var clienteExistente = _context.Cliente.FirstOrDefault(x => x.IdCliente == IdCliente);
            _context.Cliente.Remove(clienteExistente);
            _context.SaveChanges();
        }
    }
}

