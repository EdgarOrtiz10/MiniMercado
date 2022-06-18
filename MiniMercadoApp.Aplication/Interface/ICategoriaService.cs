using MinimercadoApp.Application.Requests;
using MiniMercadoApp.Aplication.Response;
using MiniMercadoApp.Application.Requests;
using MiniMercadoApp.Domain.Entities;

namespace MiniMercadoApp.Aplication.Interface
{
    public interface ICategoriaService
    {
        CategoriaResponse GetCategoriaById(int IdCategoria);
        IEnumerable<CategoriaResponse> GetCategoria();

        void InsertCategoria(CreateCategoriaRequest categoria);

        void UpdateCategoria(UpdateCategoriaRequest categoria);

        void DeleteCategoria(int IdCategoria);
    }
}
