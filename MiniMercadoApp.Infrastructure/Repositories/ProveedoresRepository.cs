using MinimercadoApp.Domain.Interfaces;
using MiniMercadoApp.Domain.Entities;
using MiniMercadoApp.Infrastructure.Persistance;

namespace MiniMercadoApp.Infrastructure.Repositories
{
    public class ProveedoresRepository : IProveedoresRepository
    {
        private MiniMercadoContext _context;
        public ProveedoresRepository(MiniMercadoContext context)
        {
            _context = context;
        }

        public IEnumerable<Proveedores> GetProveedores()
        {
            return _context.Proveedoress;
        }

        public Proveedores GetProveedoresById(int IdProveedores)
        {
            return _context.Proveedoress.FirstOrDefault(x => x.IdProveedor == IdProveedores);
        }

        public void InsertProveedores(Proveedores proveedores)
        {
            _context.Proveedoress.Add(proveedores);
            _context.SaveChanges();
        }

        public void UpdateProveedores(Proveedores proveedores)
        {
            var proveedoresExistente = _context.Proveedoress.FirstOrDefault(x => x.IdProveedor == proveedores.IdProveedor);
            proveedoresExistente.NombreProveedor = proveedores.NombreProveedor;
            proveedoresExistente.DireccionProveedor = proveedores.DireccionProveedor;
            _context.SaveChanges();
        }

        public void DeleteProveedores(int IdProveedores)
        {
            var proveedoresExistente = _context.Proveedoress.FirstOrDefault(x => x.IdProveedor == IdProveedores);
            _context.Proveedoress.Remove(proveedoresExistente);
            _context.SaveChanges();
        }
    }
}

