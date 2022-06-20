using AutoMapper;
using MinimercadoApp.Application.Requests;
using MinimercadoApp.Domain.Interfaces;
using MiniMercadoApp.Aplication.Interface;
using MiniMercadoApp.Aplication.Response;
using MiniMercadoApp.Application.Requests;
using MiniMercadoApp.Domain.Entities;

namespace MiniMercadoApp.Aplication.Services
{
    public class LoginService : ILoginService
    {
        private readonly ILoginRepository _repository;
        private readonly IMapper _mapper;

        public LoginService(ILoginRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        
        
        public void DeleteLogin(int IdUser)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LoginResponse> GetLogin()
        {
            var login = _repository.GetLogin();
            var loginResponse = _mapper.Map<IEnumerable<LoginResponse>>(login);
            return loginResponse;
        }

        public LoginResponse GetLoginById(int IdUser)
        {
            // Convertimos de 
            var login = _repository.GetLoginById(IdUser);
            var loginResponse = _mapper.Map<LoginResponse>(login);
            return loginResponse;
        }

        public void InsertLogin(CreateLoginRequest request)
        {
            throw new NotImplementedException();
        }
        /*
        public void UpdateLogin(UpdateLoginRequest request)
        {
            throw new NotImplementedException();
        }*/
    }
}
