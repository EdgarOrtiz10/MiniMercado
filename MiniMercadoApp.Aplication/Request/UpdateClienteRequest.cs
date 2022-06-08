using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimercadoApp.Application.Requests
{
    public class UpdateClienteRequest
    {
        public int IdCliente { get; set; }
        public string Nombre1 { get; set; }

        public string Nombre2 { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }

        public string Direccion { get; set; }

        public int Telefono { get; set; }
        public string Sexo { get; set; }

        public string Correo { get; set; }
    }
}