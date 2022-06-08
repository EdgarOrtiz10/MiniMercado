using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMercadoApp.Application.Requests
{
    public class CreateCategoriaRequest
    {
        public int IdCategoria { get; set; }
        public string NombreCategoria { get; set; }

        public string Descripcion { get; set; }

    }
}
