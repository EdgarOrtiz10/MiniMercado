using MinimercadoApp.Domain.Interfaces;
using MiniMercadoApp.Domain.Entities;
using MiniMercadoApp.Infrastructure.Persistance;

namespace MiniMercadoApp.Infrastructure.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private MiniMercadoContext _context;
        public CategoriaRepository(MiniMercadoContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> GetCategoria()
        {
            return _context.Categoria;
        }

        public Categoria GetCategoriaById(int IdCategoria)
        {
            return _context.Categoria.FirstOrDefault(x => x.IdCategoria == IdCategoria);
        }

        public void InsertCategoria(Categoria categoria)
        {
            _context.Categoria.Add(categoria);
            _context.SaveChanges();
        }

        public void UpdateCategoria(Categoria categoria)
        {
            var categoriaExistente = _context.Categoria.FirstOrDefault(x => x.IdCategoria == categoria.IdCategoria);
            categoriaExistente.NombreCategoria = categoria.NombreCategoria;
            categoriaExistente.Descripcion = categoria.Descripcion;
            _context.SaveChanges();
        }

        public void DeleteCategoria(int IdCategoria)
        {
            var categoriaExistente = _context.Categoria.FirstOrDefault(x => x.IdCategoria == IdCategoria);
            _context.Categoria.Remove(categoriaExistente);
            _context.SaveChanges();
        }
    }
}

