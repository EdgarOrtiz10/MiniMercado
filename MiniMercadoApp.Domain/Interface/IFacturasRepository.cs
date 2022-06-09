using MiniMercadoApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MinimercadoApp.Domain.Interfaces
{
    public interface IFacturasRepository
    {
        Factura GetFacturaById(int idFactura);
        IEnumerable<Factura> GetFactura();

        void InsertFactura(Factura factura);

        void UpdateFactura(Factura factura);

        void DeleteFactura(int idFactura);
    }
}
