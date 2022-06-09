using MiniMercadoApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MinimercadoApp.Domain.Interfaces
{
    public interface IProductosRepository
    {
        Productos GetProductoById(int idProducto);
        IEnumerable<Productos> GetProducto();

        void InsertProducto(Productos Producto);

        void UpdateProducto(Productos Producto);

        void DeleteProducto(int idProducto);
    }
}