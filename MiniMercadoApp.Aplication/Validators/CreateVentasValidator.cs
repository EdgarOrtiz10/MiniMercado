using FluentValidation;
using MinimercadoApp.Application.Requests;
using MiniMercadoApp.Application.Requests;

namespace MiniMercadoApp.Aplication.Validators
{
    public class CreateVentasValidator : AbstractValidator<CreateVentasRequest>
    {
        public CreateVentasValidator()
        {
            RuleFor(x => x.IdVenta)
                .NotEmpty()
                .WithMessage("La Identificación de la Venta es requerida");

            RuleFor(x => x.IdFactura)
                .NotEmpty()
                .WithMessage("La Identificación de la Factura es requerida");

            RuleFor(x => x.IdProducto)
                .NotEmpty()
                .WithMessage("La Identificación del Producto es requerido");

            RuleFor(x => x.Cantidad)
                .NotEmpty()
                .WithMessage("Cantidad es requerida");

        }
    }

    public class UpdateVentasValidator : AbstractValidator<UpdateVentasRequest>
    {
        public UpdateVentasValidator()
        {
            RuleFor(x => x.IdVenta)
                .NotEmpty()
                .WithMessage("La Identificación de la Venta es requerida");

            RuleFor(x => x.IdFactura)
                .NotEmpty()
                .WithMessage("La Identificación de la Factura es requerida");

            RuleFor(x => x.IdProducto)
                .NotEmpty()
                .WithMessage("La Identificación del Producto es requerido");

            RuleFor(x => x.Cantidad)
                .NotEmpty()
                .WithMessage("Cantidad es requerida");
        }
    }

    public class DeleteVentasValidator : AbstractValidator<DeleteVentasRequest>
    {
        public DeleteVentasValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("La Identificación de la Venta es requerida");
        }
    }
}
