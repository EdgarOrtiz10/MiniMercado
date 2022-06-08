using System;
using System.Collections.Generic;

namespace MiniMercadoApp.Domain.Entities
{
    public partial class TblCategoria
    {
        public TblCategoria()
        {
            TblProductos = new HashSet<TblProducto>();
        }

        public decimal IdCategoria { get; set; }
        public string NombreCategoria { get; set; } = null!;
        public string? Descripcion { get; set; }

        public virtual ICollection<TblProducto> TblProductos { get; set; }
    }
}
