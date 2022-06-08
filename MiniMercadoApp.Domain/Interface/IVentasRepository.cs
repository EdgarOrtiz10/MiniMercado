using MiniMercadoApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MinimercadoApp.Domain.Interfaces
{
    public interface IVentasRepository
    {
        TblVenta GetVentasById(int idventas);
        IEnumerable<TblVenta> GetVentas();

        void InsertVentas(TblVenta Ventas);

        void UpdateVentas(TblVenta Ventas);

        void DeleteVentas(int idVentas);
    }
}
