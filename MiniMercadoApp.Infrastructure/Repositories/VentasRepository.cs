using MinimercadoApp.Domain.Interfaces;
using MiniMercadoApp.Domain.Entities;
using MiniMercadoApp.Infrastructure.Persistance;

namespace MiniMercadoApp.Infrastructure.Repositories
{
    public class VentasRepository : IVentasRepository
    {
        private MiniMercadoContext _context;
        public VentasRepository(MiniMercadoContext context)
        {
            _context = context;
        }

        public IEnumerable<TblVenta> GetVentas()
        {
            return _context.TblVentas;
        }

        public TblVenta GetVentasById(int IdVentas)
        {
            return _context.TblVentas.FirstOrDefault(x => x.IdVenta == IdVentas);
        }

        public TblVenta GetSalaById(int IdVenta)
        {
            return _context.TblVentas.FirstOrDefault(x => x.IdVenta == IdVenta);
        }

        public void InsertVentas(TblVenta ventas)
        {
            _context.TblVentas.Add(ventas);
            _context.SaveChanges();
        }

        public void UpdateVentas(TblVenta ventas)
        {
            var ventaExistente = _context.TblVentas.FirstOrDefault(x => x.IdVenta == ventas.IdVenta);
            ventaExistente.IdVenta = ventas.IdVenta;
            ventaExistente.IdFactura = ventas.IdFactura;
            ventaExistente.IdProducto = ventas.IdProducto;
            ventaExistente.Cantidad = ventas.Cantidad;
            _context.SaveChanges();
        }

        public void DeleteVentas(int IdVentas)
        {
            var ventasExistente = _context.TblVentas.FirstOrDefault(x => x.IdVenta == IdVentas);
            _context.TblVentas.Remove(ventasExistente);
            _context.SaveChanges();
        }
    }
}

