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
    public class ProductosController : ControllerBase
    {
        private readonly IProductosRepository _repository;
        private readonly IMapper _mapper;

        public ProductosController(IProductosRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.GetProducto());
        }


        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] GetProductosByIdRequest request)
        {
            return Ok(_repository.GetProductoById(request.Id));
        }


        [HttpPost]
        public IActionResult Post(CreateProductosRequest request)
        {
            var Productos = _mapper.Map<TblProducto>(request);
            _repository.InsertProducto(Productos);
            return Ok();
        }

        [HttpPut]
        public IActionResult Put(UpdateProductosRequest request)
        {
            var Productos = _mapper.Map<TblProducto>(request);
            _repository.UpdateProducto(Productos);
            return Ok();
        }

        [HttpPut]
        public IActionResult put(UpdateProductosRequest request)
        {
            var Productos = _mapper.Map<TblProducto>(request);
            _repository.UpdateProducto(Productos);
            return Ok();
        }


        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] DeleteProductosRequest request)
        {
            _repository.DeleteProducto(request.Id);
            return Ok();
        }

    }
}
