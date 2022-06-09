using System;
using System.Collections.Generic;

namespace MiniMercadoApp.Domain.Entities
{
    public partial class Productos
    {
        public Productos()
        {
            Ventas = new HashSet<Ventas>();
        }

        public decimal IdProducto { get; set; }
        public string? DescripcionProducto { get; set; }
        public decimal Precio { get; set; }
        public decimal IdCategoria { get; set; }
        public decimal IdProveedor { get; set; }

        public virtual Categoria IdCategoriaNavigation { get; set; } = null!;
        public virtual Proveedores IdProveedorNavigation { get; set; } = null!;
        public virtual ICollection<Ventas> Ventas { get; set; }
    }
}
