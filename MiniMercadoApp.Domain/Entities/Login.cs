using System;
using System.Collections.Generic;

namespace MiniMercadoApp.Domain.Entities
{
    public partial class Login
    {
        public decimal IdUser { get; set; }
        public string Pass { get; set; } = null!;
        public decimal Active { get; set; }
    }
}
