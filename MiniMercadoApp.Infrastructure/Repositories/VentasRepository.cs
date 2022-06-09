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

        public IEnumerable<Ventas> GetVentas()
        {
            return _context.Ventass;
        }

        public Ventas GetVentasById(int IdVentas)
        {
            return _context.Ventass.FirstOrDefault(x => x.IdVenta == IdVentas);
        }

        public Ventas GetSalaById(int IdVenta)
        {
            return _context.Ventass.FirstOrDefault(x => x.IdVenta == IdVenta);
        }

        public void InsertVentas(Ventas ventas)
        {
            _context.Ventass.Add(ventas);
            _context.SaveChanges();
        }

        public void UpdateVentas(Ventas ventas)
        {
            var ventaExistente = _context.Ventass.FirstOrDefault(x => x.IdVenta == ventas.IdVenta);
            ventaExistente.IdVenta = ventas.IdVenta;
            ventaExistente.IdFactura = ventas.IdFactura;
            ventaExistente.IdProducto = ventas.IdProducto;
            ventaExistente.Cantidad = ventas.Cantidad;
            _context.SaveChanges();
        }

        public void DeleteVentas(int IdVentas)
        {
            var ventasExistente = _context.Ventass.FirstOrDefault(x => x.IdVenta == IdVentas);
            _context.Ventass.Remove(ventasExistente);
            _context.SaveChanges();
        }
    }
}

