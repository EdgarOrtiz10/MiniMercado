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
    public class ProveedoresController : ControllerBase
    {
        private readonly IProveedoresRepository _repository;
        private readonly IMapper _mapper;

        public ProveedoresController(IProveedoresRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.GetProveedores());
        }


        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] GetProveedoresByIdRequest request)
        {
            return Ok(_repository.GetProveedoresById(request.Id));
        }


        [HttpPost]
        public IActionResult Post(CreateProveedoresRequest request)
        {
            var Proveedores = _mapper.Map<TblProveedore>(request);
            _repository.InsertProveedores(Proveedores);
            return Ok();
        }

        [HttpPut]
        public IActionResult Put(UpdateProveedoresRequest request)
        {
            var Proveedores = _mapper.Map<TblProveedore>(request);
            _repository.UpdateProveedores(Proveedores);
            return Ok();
        }

        [HttpPut]
        public IActionResult put(UpdateProveedoresRequest request)
        {
            var Proveedores = _mapper.Map<TblProveedore>(request);
            _repository.UpdateProveedores(Proveedores);
            return Ok();
        }


        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] DeleteProveedoresRequest request)
        {
            _repository.DeleteProveedores(request.Id);
            return Ok();
        }

    }
}
