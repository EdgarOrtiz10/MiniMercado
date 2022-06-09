using System;
using System.Collections.Generic;

namespace MiniMercadoApp.Domain.Entities
{
    public partial class Ventas
    {
        public decimal IdVenta { get; set; }
        public decimal IdFactura { get; set; }
        public decimal IdProducto { get; set; }
        public decimal Cantidad { get; set; }

        public virtual Factura IdFacturaNavigation { get; set; } = null!;
        public virtual Productos IdProductoNavigation { get; set; } = null!;
    }
}
