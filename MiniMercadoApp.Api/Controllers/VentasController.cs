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
    public class VentasController : ControllerBase
    {
        private readonly IVentasRepository _repository;
        private readonly IMapper _mapper;

        public VentasController(IVentasRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.GetVentas());
        }


        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] GetVentasByIdRequest request)
        {
            return Ok(_repository.GetVentasById(request.Id));
        }


        [HttpPost]
        public IActionResult Post(CreateVentasRequest request)
        {
            var ventas = _mapper.Map<TblVenta>(request);
            _repository.InsertVentas(ventas);
            return Ok();
        }

        [HttpPut]
        public IActionResult Put(UpdateVentasRequest request)
        {
            var ventas = _mapper.Map<TblVenta>(request);
            _repository.UpdateVentas(ventas);
            return Ok();
        }

        [HttpPut]
        public IActionResult put(UpdateVentasRequest request)
        {
            var ventas = _mapper.Map<TblVenta>(request);
            _repository.UpdateVentas(ventas);
            return Ok();
        }


        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] DeleteVentasRequest request)
        {
            _repository.DeleteVentas(request.Id);
            return Ok();
        }

    }
}
