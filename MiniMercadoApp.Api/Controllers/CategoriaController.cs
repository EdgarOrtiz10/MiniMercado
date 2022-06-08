using AutoMapper;
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
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaRepository _repository;
        private readonly IMapper _mapper;

        public CategoriaController(ICategoriaRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.GetCategoria());
        }

        
        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] GetCategoriaByIdRequest request)
        {
            return Ok(_repository.GetCategoriaById(request.Id));
        }


        [HttpPost]
        public IActionResult Post(CreateCategoriaRequest request)
        {
            var categoria = _mapper.Map<TblCategoria>(request);
            _repository.InsertCategoria(categoria);
            return Ok();
        }

        [HttpPut]
        public IActionResult Put(UpdateCategoriaRequest request)
        {
            var categoria = _mapper.Map<TblCategoria>(request);
            _repository.UpdateCategoria(categoria);
            return Ok();
        }

        [HttpPut]
        public IActionResult put(UpdateCategoriaRequest request)
        {
            var categoria = _mapper.Map<TblCategoria>(request);
            _repository.UpdateCategoria(categoria);
            return Ok();
        }


        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] DeleteClienteRequest request)
        {
            _repository.DeleteCategoria(request.Id);
            return Ok();
        }

    }
}
