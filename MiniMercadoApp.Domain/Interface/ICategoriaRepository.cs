using MiniMercadoApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MinimercadoApp.Domain.Interfaces
{
    public interface ICategoriaRepository
    {
        TblCategoria GetCategoriaById(int IdCategoria);
        IEnumerable<TblCategoria> GetCategoria();

        void InsertCategoria(TblCategoria categoria);

        void UpdateCategoria(TblCategoria categoria);

        void DeleteCategoria(int IdCategoria);
    }
}
