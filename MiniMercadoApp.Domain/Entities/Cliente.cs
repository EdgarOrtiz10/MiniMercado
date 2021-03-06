using System;
using System.Collections.Generic;

namespace MiniMercadoApp.Domain.Entities
{
    public partial class Cliente
    {
        public Cliente()
        {
            Facturas = new HashSet<Factura>();
        }

        public decimal IdCliente { get; set; }
        public string Nombre1 { get; set; } = null!;
        public string? Nombre2 { get; set; }
        public string Apellido1 { get; set; } = null!;
        public string? Apellido2 { get; set; }
        public string Direccion { get; set; } = null!;
        public decimal Telefono { get; set; }
        public string Sexo { get; set; } = null!;
        public string? Correo { get; set; }

        public virtual ICollection<Factura> Facturas { get; set; }
    }
}
