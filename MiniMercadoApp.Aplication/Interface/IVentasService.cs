using MinimercadoApp.Application.Requests;
using MiniMercadoApp.Aplication.Response;
using MiniMercadoApp.Application.Requests;
using MiniMercadoApp.Domain.Entities;

namespace MiniMercadoApp.Aplication.Interface
{
    public interface IVentasService
    {
        VentasResponse GetVentasById(int IdVentas);
        IEnumerable<VentasResponse> GetVentas();

        void InsertVentas(CreateVentasRequest ventas);

        void UpdateVentas(UpdateVentasRequest ventas);

        void DeleteVentas(int IdVenta);
    }
}
