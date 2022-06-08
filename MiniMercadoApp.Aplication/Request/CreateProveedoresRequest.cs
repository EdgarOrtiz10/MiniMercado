using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMercadoApp.Application.Requests
{
    public class CreateProveedoresRequest
    {
       public int IdProveedor { get; set; }
        
        public string NombreProveedor { get; set; }

        public string DireccionProveedor { get; set; }

        public int TelefonoProveedor { get; set; }

        public string Correo { get; set; }

    }
}
