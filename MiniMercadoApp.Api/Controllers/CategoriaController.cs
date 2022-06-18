using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MiniMercado.Application.Requests;
using MinimercadoApp.Application.Requests;
using MinimercadoApp.Domain.Interfaces;
using MiniMercadoApp.Aplication.Interface;
using MiniMercadoApp.Application.Requests;
using MiniMercadoApp.Domain.Entities;

namespace MiniMercadoApp.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaService _service;

        public CategoriaController(ICategoriaService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.GetCategoria());
        }

        
        [HttpGet("{Id}")]
        public IActionResult Get([FromRoute] GetCategoriaByIdRequest request)
        {
            return Ok(_service.GetCategoriaById(request.Id));
        }


        [HttpPost]
        public IActionResult Post(CreateCategoriaRequest request)
        {
            _service.InsertCategoria(request);
            return Ok();
        }

        [HttpPut]
        public IActionResult Put(UpdateCategoriaRequest request)
        {
            _service.UpdateCategoria(request);
            return Ok();
        }


        [HttpDelete("{Id}")]
        public IActionResult Delete([FromRoute] DeleteClienteRequest request)
        {
            _service.DeleteCategoria(request.Id);
            return Ok();
        }

    }
}
