using System;
using System.Collections.Generic;

namespace MiniMercadoApp.Domain.Entities
{
    public partial class Categoria
    {
        public Categoria()
        {
            Productoss = new HashSet<Productos>();
        }

        public decimal IdCategoria { get; set; }
        public string NombreCategoria { get; set; } = null!;
        public string? Descripcion { get; set; }

        public virtual ICollection<Productos> Productoss { get; set; }
    }
}
