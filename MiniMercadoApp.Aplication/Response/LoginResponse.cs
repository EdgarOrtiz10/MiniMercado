using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMercadoApp.Aplication.Response
{
    public class LoginResponse
    {
        public decimal IdUser { get; set; }
        public string Pass { get; set; } = null!;
        public decimal Active { get; set; }
    }
}
