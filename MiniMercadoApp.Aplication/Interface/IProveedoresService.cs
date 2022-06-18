using MinimercadoApp.Application.Requests;
using MiniMercadoApp.Aplication.Response;
using MiniMercadoApp.Application.Requests;
using MiniMercadoApp.Domain.Entities;

namespace MiniMercadoApp.Aplication.Interface
{
    public interface IProveedoresService
    {
        ProveedoresResponse GetProveedoresById(int IdProveedores);
        IEnumerable<ProveedoresResponse> GetProveedores();

        void InsertProveedores(CreateProveedoresRequest proveedores);

        void UpdateProveedores(UpdateProveedoresRequest proveedores);

        void DeleteProveedores(int IdProveedor);
    }
}
