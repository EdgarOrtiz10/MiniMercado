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

        public IEnumerable<TblProveedore> GetProveedores()
        {
            return _context.TblProveedores;
        }

        public TblProveedore GetProveedoresById(int IdProveedores)
        {
            return _context.TblProveedores.FirstOrDefault(x => x.IdProveedor == IdProveedores);
        }

        public void InsertProveedores(TblProveedore proveedores)
        {
            _context.TblProveedores.Add(proveedores);
            _context.SaveChanges();
        }

        public void UpdateProveedores(TblProveedore proveedores)
        {
            var proveedoresExistente = _context.TblProveedores.FirstOrDefault(x => x.IdProveedor == proveedores.IdProveedor);
            proveedoresExistente.NombreProveedor = proveedores.NombreProveedor;
            proveedoresExistente.DireccionProveedor = proveedores.DireccionProveedor;
            _context.SaveChanges();
        }

        public void DeleteProveedores(int IdProveedores)
        {
            var proveedoresExistente = _context.TblProveedores.FirstOrDefault(x => x.IdProveedor == IdProveedores);
            _context.TblProveedores.Remove(proveedoresExistente);
            _context.SaveChanges();
        }
    }
}

