using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMercadoApp.Application.Requests
{
    public class CreateFacturasRequest
    {
        public int IdFactura { get; set; }
        public DateTime Fecha { get; set; }

        public int ValorFactura { get; set; }

        public int IdCliente { get; set; }

    }
}
