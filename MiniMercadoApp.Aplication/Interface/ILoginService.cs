using MinimercadoApp.Application.Requests;
using MiniMercadoApp.Aplication.Response;
using MiniMercadoApp.Application.Requests;
using MiniMercadoApp.Domain.Entities;

namespace MiniMercadoApp.Aplication.Interface
{
    public interface ILoginService
    {
        LoginResponse GetLoginById(int IdUser);
        IEnumerable<LoginResponse> GetLogin();
/*
        void InsertLogin(CreateLoginRequest login);

        void UpdateLogin(UpdateLoginRequest login);

        void DeleteLogin(int IdUser);
*/
    }
}
