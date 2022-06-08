using MiniMercadoApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MinimercadoApp.Domain.Interfaces
{
    public interface IClienteRepository
    {
        TblCliente GetClienteById(int IdCliente);
        IEnumerable<TblCliente> GetCliente();

        void InsertCliente(TblCliente cliente);

        void UpdateCliente(TblCliente cliente);

        void DeleteCliente(int IdCliente);
    }
}
