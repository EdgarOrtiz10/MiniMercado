using MiniMercadoApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MinimercadoApp.Domain.Interfaces
{ 
    public interface ICategoriaRepository
    {
        Categoria GetCategoriaById(int IdCategoria);
        IEnumerable<Categoria> GetCategoria();

        void InsertCategoria(Categoria categoria);

        void UpdateCategoria(Categoria categoria);

        void DeleteCategoria(int IdCategoria);
    }
}
