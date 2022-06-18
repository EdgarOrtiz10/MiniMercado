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
    public class ClienteController : ControllerBase
    {
        private readonly IClienteRepository _repository;
        private readonly IMapper _mapper;

        public ClienteController(IClienteRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.GetCliente());
        }


        [HttpGet("{Id}")]
        public IActionResult Get([FromRoute] GetClienteByIdRequest request)
        {
            return Ok(_repository.GetClienteById(request.Id));
        }


        [HttpPut]
        public IActionResult Put(UpdateClienteRequest request)
        {
            var cliente = _mapper.Map<Cliente>(request);
            _repository.UpdateCliente(cliente);
            return Ok();
        }

        [HttpDelete("{Id}")]
        public IActionResult Delete([FromRoute] DeleteClienteRequest request)
        {
            _repository.DeleteCliente(request.Id);
            return Ok();
        }

    }
}
