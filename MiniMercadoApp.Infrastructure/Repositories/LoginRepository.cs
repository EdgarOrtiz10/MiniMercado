using MinimercadoApp.Domain.Interfaces;
using MiniMercadoApp.Domain.Entities;
using MiniMercadoApp.Infrastructure.Persistance;

namespace MiniMercadoApp.Infrastructure.Repositories
{
    public class LoginRepository : ILoginRepository
    {
        private MiniMercadoContext _context;
        public LoginRepository(MiniMercadoContext context)
        {
            _context = context;
        }

        public IEnumerable<Login> GetLogin()
        {
            return _context.Login;
        }

        public Login GetLoginById(int IdUser)
        {
            return _context.Login.FirstOrDefault(x => x.IdUser == IdUser);
        }

        public void InsertLogin(Login login)
        {
            _context.Login.Add(login);
            _context.SaveChanges();
        }

        public void UpdateLogin(Login login)
        {
            var loginExistente = _context.Login.FirstOrDefault(x => x.IdUser == login.IdUser);
            loginExistente.IdUser = login.IdUser;
            loginExistente.Pass = login.Pass;
            loginExistente.Active = login.Active;
            _context.SaveChanges();
        }

        public void DeleteLogin(int IdUser)
        {
            var loginExistente = _context.Login.FirstOrDefault(x => x.IdUser == IdUser);
            _context.Login.Remove(loginExistente);
            _context.SaveChanges();
        }
    }
}

