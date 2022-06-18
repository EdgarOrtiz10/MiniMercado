using MiniMercadoApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMercadoApp.Aplication.Response
{
    public class VentasResponse
    {
        public decimal IdVenta { get; set; }
        public decimal IdFactura { get; set; }
        public decimal IdProducto { get; set; }
        public decimal Cantidad { get; set; }

        public virtual Factura IdFacturaNavigation { get; set; } = null!;
        public virtual Productos IdProductoNavigation { get; set; } = null!;
    }
}
