using MinimercadoApp.Application.Requests;
using MiniMercadoApp.Aplication.Response;
using MiniMercadoApp.Application.Requests;
using MiniMercadoApp.Domain.Entities;

namespace MiniMercadoApp.Aplication.Interface
{
    public interface IFacturaService
    {
        FacturaResponse GetFacturaById(int IdFactura);
        IEnumerable<FacturaResponse> GetFactura();

        void InsertFactura(CreateFacturasRequest factura);

        void UpdateFactura(UpdateFacturasRequest factura);

        void DeleteFactura(int IdFactura);
    }
}
