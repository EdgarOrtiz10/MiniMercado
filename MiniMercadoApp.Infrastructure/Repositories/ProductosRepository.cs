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

        public IEnumerable<TblProducto> GetProducto()
        {
            return _context.TblProductos;
        }

        public TblProducto GetProductoById(int IdProducto)
        {
            return _context.TblProductos.FirstOrDefault(x => x.IdProducto == IdProducto);
        }

        public void InsertProducto(TblProducto productos)
        {
            _context.TblProductos.Add(productos);
            _context.SaveChanges();
        }

        public void UpdateProducto(TblProducto productos)
        {
            var productosExistente = _context.TblProductos.FirstOrDefault(x => x.IdProducto == productos.IdProducto);
            productosExistente.IdProducto = productos.IdProducto;
            productosExistente.DescripcionProducto = productos.DescripcionProducto;
            productosExistente.Precio = productos.Precio;
            productosExistente.IdCategoria = productos.IdCategoria;
            productosExistente.IdProveedor = productos.IdProveedor;
            _context.SaveChanges();
        }

        public void DeleteProducto(int IdProducto)
        {
            var productoExistente = _context.TblProductos.FirstOrDefault(x => x.IdProducto == IdProducto);
            _context.TblProductos.Remove(productoExistente);
            _context.SaveChanges();
        }
    }
}

