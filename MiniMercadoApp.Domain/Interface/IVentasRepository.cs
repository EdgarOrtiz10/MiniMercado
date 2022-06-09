using MiniMercadoApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MinimercadoApp.Domain.Interfaces
{
    public interface IVentasRepository
    {
        Ventas GetVentasById(int idventas);
        IEnumerable<Ventas> GetVentas();

        void InsertVentas(Ventas Ventas);

        void UpdateVentas(Ventas Ventas);

        void DeleteVentas(int idVentas);
    }
}
