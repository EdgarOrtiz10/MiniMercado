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

        public IEnumerable<TblCategoria> GetCategoria()
        {
            return _context.TblCategoria;
        }

        public TblCategoria GetCategoriaById(int IdCategoria)
        {
            return _context.TblCategoria.FirstOrDefault(x => x.IdCategoria == IdCategoria);
        }

        public void InsertCategoria(TblCategoria categoria)
        {
            _context.TblCategoria.Add(categoria);
            _context.SaveChanges();
        }

        public void UpdateCategoria(TblCategoria categoria)
        {
            var categoriaExistente = _context.TblCategoria.FirstOrDefault(x => x.IdCategoria == categoria.IdCategoria);
            categoriaExistente.NombreCategoria = categoria.NombreCategoria;
            categoriaExistente.Descripcion = categoria.Descripcion;
            _context.SaveChanges();
        }

        public void DeleteCategoria(int IdCategoria)
        {
            var categoriaExistente = _context.TblCategoria.FirstOrDefault(x => x.IdCategoria == IdCategoria);
            _context.TblCategoria.Remove(categoriaExistente);
            _context.SaveChanges();
        }
    }
}

