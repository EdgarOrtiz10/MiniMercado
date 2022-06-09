using MiniMercadoApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MinimercadoApp.Domain.Interfaces
{
    public interface IClienteRepository
    {
        Cliente GetClienteById(int IdCliente);
        IEnumerable<Cliente> GetCliente();

        void InsertCliente(Cliente cliente);

        void UpdateCliente(Cliente cliente);

        void DeleteCliente(int IdCliente);
    }
}
