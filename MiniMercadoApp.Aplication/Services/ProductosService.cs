using AutoMapper;
using MinimercadoApp.Application.Requests;
using MinimercadoApp.Domain.Interfaces;
using MiniMercadoApp.Aplication.Interface;
using MiniMercadoApp.Aplication.Response;
using MiniMercadoApp.Application.Requests;
using MiniMercadoApp.Domain.Entities;

namespace MiniMercadoApp.Aplication.Services
{
    public class ProductosService : IProductosService
    {
        private readonly IProductosRepository _repository;
        private readonly IMapper _mapper;

        public ProductosService(IProductosRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void DeleteProductos(int IdProducto)
        {
            _repository.DeleteProducto(IdProducto);
        }

        public IEnumerable<ProductosResponse> GetProductos()
        {
            var productos = _repository.GetProducto();
            var productosResponse = _mapper.Map<IEnumerable<ProductosResponse>>(productos);
            return productosResponse;
        }

        public ProductosResponse GetProductosById(int IdProductos)
        {
            // Convertimos de 
            var productos = _repository.GetProductoById(IdProductos);
            var productosResponse = _mapper.Map<ProductosResponse>(productos);
            return productosResponse;
        }

        public void InsertProductos(CreateProductosRequest request)
        {
            var productos = _mapper.Map<Productos>(request);
            _repository.InsertProducto(productos);
        }

        public void UpdateProductos(UpdateProductosRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
