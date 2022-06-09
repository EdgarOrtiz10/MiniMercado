using MinimercadoApp.Domain.Interfaces;
using MiniMercadoApp.Domain.Entities;
using MiniMercadoApp.Infrastructure.Persistance;

namespace MiniMercadoApp.Infrastructure.Repositories
{
    public class FacturasRepository : IFacturasRepository
    {
        private MiniMercadoContext _context;
        public FacturasRepository(MiniMercadoContext context)
        {
            _context = context;
        }

        public IEnumerable<Factura> GetFactura()
        {
            return _context.Facturas;
        }

        public Factura GetFacturaById(int IdFactura)
        {
            return _context.Facturas.FirstOrDefault(x => x.IdFactura == IdFactura);
        }

        public void InsertFactura(Factura facturas)
        {
            _context.Facturas.Add(facturas);
            _context.SaveChanges();
        }

        public void UpdateFactura(Factura facturas)
        {
            var facturasExistente = _context.Facturas.FirstOrDefault(x => x.IdFactura == facturas.IdFactura);
            facturasExistente.IdFactura = facturas.IdFactura;
            facturasExistente.Fecha = facturas.Fecha;
            facturasExistente.ValorFactura = facturas.ValorFactura;
            facturasExistente.IdCliente = facturas.IdCliente;

            _context.SaveChanges();
        }

        public void DeleteFactura(int IdFacturas)
        {
            var facturaExistente = _context.Facturas.FirstOrDefault(x => x.IdFactura == IdFacturas);
            _context.Facturas.Remove(facturaExistente);
            _context.SaveChanges();
        }
    }
}

