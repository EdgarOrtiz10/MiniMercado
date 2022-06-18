using AutoMapper;
using MinimercadoApp.Application.Requests;
using MinimercadoApp.Domain.Interfaces;
using MiniMercadoApp.Aplication.Interface;
using MiniMercadoApp.Aplication.Response;
using MiniMercadoApp.Application.Requests;
using MiniMercadoApp.Domain.Entities;

namespace MiniMercadoApp.Aplication.Services
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _repository;
        private readonly IMapper _mapper;

        public CategoriaService(ICategoriaRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void DeleteCategoria(int IdCategoria)
        {
            _repository.DeleteCategoria(IdCategoria);
        }

        public IEnumerable<CategoriaResponse> GetCategoria()
        {
            var categoria = _repository.GetCategoria();
            var categoriaResponse = _mapper.Map<IEnumerable<CategoriaResponse>>(categoria);
            return categoriaResponse;
        }

        public CategoriaResponse GetCategoriaById(int IdCategoria)
        {
            // Convertimos de 
            var categoria = _repository.GetCategoriaById(IdCategoria);
            var categoriaResponse = _mapper.Map<CategoriaResponse>(categoria);
            return categoriaResponse;
        }

        public void InsertCategoria(CreateCategoriaRequest request)
        {
            var categoria = _mapper.Map<Categoria>(request);
            _repository.InsertCategoria(categoria);
        }

        public void UpdateCategoria(UpdateCategoriaRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
