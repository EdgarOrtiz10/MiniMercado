using System;
using System.Collections.Generic;

namespace MiniMercadoApp.Domain.Entities
{
    public partial class TblFactura
    {
        public TblFactura()
        {
            TblVenta = new HashSet<TblVenta>();
        }

        public decimal IdFactura { get; set; }
        public DateTime Fecha { get; set; }
        public decimal ValorFactura { get; set; }
        public decimal IdCliente { get; set; }

        public virtual TblCliente IdClienteNavigation { get; set; } = null!;
        public virtual ICollection<TblVenta> TblVenta { get; set; }
    }
}
