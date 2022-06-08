using MiniMercadoApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MinimercadoApp.Domain.Interfaces
{
    public interface IProveedoresRepository
    {
        TblProveedore GetProveedoresById(int IdProveedor);
        IEnumerable<TblProveedore> GetProveedores();

        void InsertProveedores(TblProveedore Proveedores);

        void UpdateProveedores(TblProveedore Proveedores);

        void DeleteProveedores(int IdProveedor);
    }
}
