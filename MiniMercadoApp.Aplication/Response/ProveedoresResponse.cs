using MiniMercadoApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMercadoApp.Aplication.Response
{
    public class ProveedoresResponse
    {
        public decimal IdFactura { get; set; }
        public DateTime Fecha { get; set; }
        public decimal ValorFactura { get; set; }
        public decimal IdCliente { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; } = null!;
        public virtual ICollection<Ventas> Ventas { get; set; }
    }
}
