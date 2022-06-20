using MiniMercadoApp.Domain.Entities;

namespace MinimercadoApp.Domain.Interfaces
{
    public interface ILoginRepository
    {
        Login GetLoginById(int IdUser);
        IEnumerable<Login> GetLogin();
/*
        void InsertLogin(Login login);

        void UpdateLogin(Login login);

        void DeleteLogin(int IdUser);
*/
    }
}
