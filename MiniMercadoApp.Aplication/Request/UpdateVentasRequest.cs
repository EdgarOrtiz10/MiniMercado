﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimercadoApp.Application.Requests
{
    public class UpdateVentasRequest
    {
        public int IdVenta { get; set; }

        public int IdFactura { get; set; }

        public int IdProducto { get; set; }

        public int Cantidad { get; set; }
    }
}