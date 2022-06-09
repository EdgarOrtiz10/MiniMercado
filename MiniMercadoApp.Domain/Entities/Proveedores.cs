using System;
using System.Collections.Generic;

namespace MiniMercadoApp.Domain.Entities
{
    public partial class Proveedores
    {
        public Proveedores()
        {
            Productoss = new HashSet<Productos>();
        }

        public decimal IdProveedor { get; set; }
        public string NombreProveedor { get; set; } = null!;
        public string DireccionProveedor { get; set; } = null!;
        public decimal TelefonoProveedor { get; set; }
        public string Correo { get; set; } = null!;

        public virtual ICollection<Productos> Productoss { get; set; }
    }
}
