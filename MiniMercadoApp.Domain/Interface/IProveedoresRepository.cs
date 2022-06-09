using MiniMercadoApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MinimercadoApp.Domain.Interfaces
{
    public interface IProveedoresRepository
    {
        Proveedores GetProveedoresById(int IdProveedor);
        IEnumerable<Proveedores> GetProveedores();

        void InsertProveedores(Proveedores Proveedores);

        void UpdateProveedores(Proveedores Proveedores);

        void DeleteProveedores(int IdProveedor);
    }
}
