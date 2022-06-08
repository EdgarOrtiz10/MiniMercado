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

        public IEnumerable<TblFactura> GetFactura()
        {
            return _context.TblFacturas;
        }

        public TblFactura GetFacturaById(int IdFactura)
        {
            return _context.TblFacturas.FirstOrDefault(x => x.IdFactura == IdFactura);
        }

        public void InsertFactura(TblFactura facturas)
        {
            _context.TblFacturas.Add(facturas);
            _context.SaveChanges();
        }

        public void UpdateFactura(TblFactura facturas)
        {
            var facturasExistente = _context.TblFacturas.FirstOrDefault(x => x.IdFactura == facturas.IdFactura);
            facturasExistente.IdFactura = facturas.IdFactura;
            facturasExistente.Fecha = facturas.Fecha;
            facturasExistente.ValorFactura = facturas.ValorFactura;
            facturasExistente.IdCliente = facturas.IdCliente;

            _context.SaveChanges();
        }

        public void DeleteFactura(int IdFacturas)
        {
            var facturaExistente = _context.TblFacturas.FirstOrDefault(x => x.IdFactura == IdFacturas);
            _context.TblFacturas.Remove(facturaExistente);
            _context.SaveChanges();
        }
    }
}

