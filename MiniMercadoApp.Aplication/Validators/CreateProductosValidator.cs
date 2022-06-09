using FluentValidation;
using MinimercadoApp.Application.Requests;
using MiniMercadoApp.Application.Requests;

namespace MiniMercadoApp.Aplication.Validators
{
    public class CreateProductosValidator : AbstractValidator<CreateProductosRequest>
    {
        public CreateProductosValidator()
        {
            RuleFor(x => x.IdProducto)
                .NotEmpty()
                .WithMessage("La Identificacion del Producto es Requerido");
            RuleFor(x => x.Precio)
                .NotEmpty()
                .WithMessage("La Identificacion del Producto es Requerido");

            RuleFor(x => x.IdCategoria)
                .NotEmpty()
                .WithMessage("La Identificacion del Producto es Requerido");

            RuleFor(x => x.IdProveedor)
                .NotEmpty()
                .WithMessage("La Identificacion del Producto es Requerido");
        }
    }

    public class UpdateProductosValidator : AbstractValidator<UpdateProductosRequest>
    {
        public UpdateProductosValidator()
        {
            RuleFor(x => x.IdProducto)
                .NotEmpty()
                .WithMessage("La Identificacion del Producto es Requerido");
            RuleFor(x => x.Precio)
                .NotEmpty()
                .WithMessage("La Identificacion del Producto es Requerido");

            RuleFor(x => x.IdCategoria)
                .NotEmpty()
                .WithMessage("La Identificacion del Producto es Requerido");

            RuleFor(x => x.IdProveedor)
                .NotEmpty()
                .WithMessage("La Identificacion del Producto es Requerido");
        }
    }

    public class DeleteProductosValidator : AbstractValidator<DeleteProductosRequest>
    {
        public DeleteProductosValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("La Identificacion del Producto es Requerido");
        }
    }
}
