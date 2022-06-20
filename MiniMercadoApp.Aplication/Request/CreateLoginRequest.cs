using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMercadoApp.Application.Requests
{
    public class CreateLoginRequest
    {
        public int IdUser { get; set; }
        public string Pass { get; set; }

        public string Active { get; set; }

    }
}
