using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MiniMercado.Application.Requests;
using MinimercadoApp.Application.Requests;
using MinimercadoApp.Domain.Interfaces;
using MiniMercadoApp.Application.Requests;
using MiniMercadoApp.Domain.Entities;

namespace MiniMercadoApp.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class LoginController : ControllerBase
    {
        private readonly ILoginRepository _repository;
        private readonly IMapper _mapper;

        public LoginController(ILoginRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.GetLogin());
        }


        [HttpGet("{Id}")]
        public IActionResult Get([FromRoute] GetLoginByIdRequest request)
        {
            return Ok(_repository.GetLoginById(request.Id));
        }

        /*
        [HttpPut]
        public IActionResult Put(UpdateLoginRequest request)
        {
            var login = _mapper.Map<Login>(request);
            _repository.UpdateLogin(login);
            return Ok();
        }

        [HttpDelete("{Id}")]
        public IActionResult Delete([FromRoute] DeleteLoginRequest request)
        {
            _repository.DeleteLogin(request.Id);
            return Ok();
        }*/

    }
}
