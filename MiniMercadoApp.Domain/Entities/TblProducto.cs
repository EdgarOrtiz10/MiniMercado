using System;
using System.Collections.Generic;

namespace MiniMercadoApp.Domain.Entities
{
    public partial class TblProducto
    {
        public TblProducto()
        {
            TblVenta = new HashSet<TblVenta>();
        }

        public decimal IdProducto { get; set; }
        public string? DescripcionProducto { get; set; }
        public decimal Precio { get; set; }
        public decimal IdCategoria { get; set; }
        public decimal IdProveedor { get; set; }

        public virtual TblCategoria IdCategoriaNavigation { get; set; } = null!;
        public virtual TblProveedore IdProveedorNavigation { get; set; } = null!;
        public virtual ICollection<TblVenta> TblVenta { get; set; }
    }
}
