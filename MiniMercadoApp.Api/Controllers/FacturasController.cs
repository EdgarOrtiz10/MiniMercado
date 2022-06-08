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
    public class FacturasController : ControllerBase
    {
        private readonly IFacturasRepository _repository;
        private readonly IMapper _mapper;

        public FacturasController(IFacturasRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.GetFactura());
        }


        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] GetFacturasByIdRequest request)
        {
            return Ok(_repository.GetFacturaById(request.Id));
        }


        [HttpPost]
        public IActionResult Post(CreateFacturasRequest request)
        {
            var facturas = _mapper.Map<TblFactura>(request);
            _repository.InsertFactura(facturas);
            return Ok();
        }

        [HttpPut]
        public IActionResult Put(UpdateFacturasRequest request)
        {
            var facturas = _mapper.Map<TblFactura>(request);
            _repository.UpdateFactura(facturas);
            return Ok();
        }

        [HttpPut]
        public IActionResult put(UpdateFacturasRequest request)
        {
            var facturas = _mapper.Map<TblFactura>(request);
            _repository.UpdateFactura(facturas);
            return Ok();
        }


        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] DeleteFacturasRequest request)
        {
            _repository.DeleteFactura(request.Id);
            return Ok();
        }

    }
}
