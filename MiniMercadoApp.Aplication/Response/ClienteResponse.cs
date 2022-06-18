using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMercadoApp.Aplication.Response
{
    public class ClienteResponse
    {
        public decimal IdCliente { get; set; }
        public string Nombre1 { get; set; } = null!;
        public string? Nombre2 { get; set; }
        public string Apellido1 { get; set; } = null!;
        public string? Apellido2 { get; set; }
        public string Direccion { get; set; } = null!;
        public decimal Telefono { get; set; }
        public string Sexo { get; set; } = null!;
        public string? Correo { get; set; }
    }
}
