using System;
using System.Collections.Generic;

namespace MiniMercadoApp.Domain.Entities
{
    public partial class Factura
    {
        public Factura()
        {
            Ventas = new HashSet<Ventas>();
        }

        public decimal IdFactura { get; set; }
        public DateTime Fecha { get; set; }
        public decimal ValorFactura { get; set; }
        public decimal IdCliente { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; } = null!;
        public virtual ICollection<Ventas> Ventas { get; set; }
    }
}
