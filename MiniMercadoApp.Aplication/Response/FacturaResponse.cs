using MiniMercadoApp.Domain.Entities;

namespace MiniMercadoApp.Aplication.Response
{
    public class FacturaResponse
    {
        public decimal IdFactura { get; set; }
        public DateTime Fecha { get; set; }
        public decimal ValorFactura { get; set; }
        public decimal IdCliente { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; } = null!;
        public virtual ICollection<Ventas> Ventas { get; set; }
    }
}
