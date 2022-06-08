using System;
using System.Collections.Generic;

namespace MiniMercadoApp.Domain.Entities
{
    public partial class TblVenta
    {
        public decimal IdVenta { get; set; }
        public decimal IdFactura { get; set; }
        public decimal IdProducto { get; set; }
        public decimal Cantidad { get; set; }

        public virtual TblFactura IdFacturaNavigation { get; set; } = null!;
        public virtual TblProducto IdProductoNavigation { get; set; } = null!;
    }
}
