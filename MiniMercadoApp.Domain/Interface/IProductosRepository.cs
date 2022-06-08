using MiniMercadoApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MinimercadoApp.Domain.Interfaces
{
    public interface IProductosRepository
    {
        TblProducto GetProductoById(int idProducto);
        IEnumerable<TblProducto> GetProducto();

        void InsertProducto(TblProducto Producto);

        void UpdateProducto(TblProducto Producto);

        void DeleteProducto(int idProducto);
    }
}