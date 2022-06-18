using MiniMercadoApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMercadoApp.Aplication.Response
{
    public class ProductosResponse
    {
        public decimal IdProveedor { get; set; }
        public string NombreProveedor { get; set; } = null!;
        public string DireccionProveedor { get; set; } = null!;
        public decimal TelefonoProveedor { get; set; }
        public string Correo { get; set; } = null!;

        public virtual ICollection<Productos> Productos { get; set; }
    }
}
