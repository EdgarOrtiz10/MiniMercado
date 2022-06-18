using MinimercadoApp.Application.Requests;
using MiniMercadoApp.Aplication.Response;
using MiniMercadoApp.Application.Requests;
using MiniMercadoApp.Domain.Entities;

namespace MiniMercadoApp.Aplication.Interface
{
    public interface IProductosService
    {
        ProductosResponse GetProductosById(int IdProductos);
        IEnumerable<ProductosResponse> GetProductos();

        void InsertProductos(CreateProductosRequest Productos);

        void UpdateProductos(UpdateProductosRequest Productos);

        void DeleteProductos(int IdProducto);
    }
}
