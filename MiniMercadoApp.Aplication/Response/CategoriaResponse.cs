using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMercadoApp.Aplication.Response
{
    public class CategoriaResponse
    {
        public decimal IdCategoria { get; set; }
        public string NombreCategoria { get; set; } = null!;
        public string? Descripcion { get; set; }
    }
}
