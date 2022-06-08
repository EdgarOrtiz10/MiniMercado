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

        public IEnumerable<TblCliente> GetCliente()
        {
            return _context.TblCliente;
        }

        public TblCliente GetClienteById(int IdCliente)
        {
            return _context.TblCliente.FirstOrDefault(x => x.IdCliente == IdCliente);
        }

        public void InsertCliente(TblCliente cliente)
        {
            _context.TblCliente.Add(cliente);
            _context.SaveChanges();
        }

        public void UpdateCliente(TblCliente cliente)
        {
            var clienteExistente = _context.TblCliente.FirstOrDefault(x => x.IdCliente == cliente.IdCliente);
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
            var clienteExistente = _context.TblCliente.FirstOrDefault(x => x.IdCliente == IdCliente);
            _context.TblCliente.Remove(clienteExistente);
            _context.SaveChanges();
        }
    }
}

