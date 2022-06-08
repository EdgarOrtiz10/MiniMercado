using MiniMercadoApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MinimercadoApp.Domain.Interfaces
{
    public interface IFacturasRepository
    {
        TblFactura GetFacturaById(int idFactura);
        IEnumerable<TblFactura> GetFactura();

        void InsertFactura(TblFactura factura);

        void UpdateFactura(TblFactura factura);

        void DeleteFactura(int idFactura);
    }
}
