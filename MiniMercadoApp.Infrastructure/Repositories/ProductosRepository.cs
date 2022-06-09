using MinimercadoApp.Domain.Interfaces;
using MiniMercadoApp.Domain.Entities;
using MiniMercadoApp.Infrastructure.Persistance;

namespace MiniMercadoApp.Infrastructure.Repositories
{
    public class ProductosRepository : IProductosRepository
    {
        private MiniMercadoContext _context;
        public ProductosRepository(MiniMercadoContext context)
        {
            _context = context;
        }

        public IEnumerable<Productos> GetProducto()
        {
            return _context.Productoss;
        }

        public Productos GetProductoById(int IdProducto)
        {
            return _context.Productoss.FirstOrDefault(x => x.IdProducto == IdProducto);
        }

        public void InsertProducto(Productos productos)
        {
            _context.Productoss.Add(productos);
            _context.SaveChanges();
        }

        public void UpdateProducto(Productos productos)
        {
            var productosExistente = _context.Productoss.FirstOrDefault(x => x.IdProducto == productos.IdProducto);
            productosExistente.IdProducto = productos.IdProducto;
            productosExistente.DescripcionProducto = productos.DescripcionProducto;
            productosExistente.Precio = productos.Precio;
            productosExistente.IdCategoria = productos.IdCategoria;
            productosExistente.IdProveedor = productos.IdProveedor;
            _context.SaveChanges();
        }

        public void DeleteProducto(int IdProducto)
        {
            var productoExistente = _context.Productoss.FirstOrDefault(x => x.IdProducto == IdProducto);
            _context.Productoss.Remove(productoExistente);
            _context.SaveChanges();
        }
    }
}

