using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimercadoApp.Application.Requests
{
    public class UpdateProductosRequest
    {
        public int IdProducto { get; set; }

        public string DescripcionProducto { get; set; }

        public int Precio { get; set; }

        public int IdCategoria { get; set; }

        public int IdProveedor { get; set; }
    }
}