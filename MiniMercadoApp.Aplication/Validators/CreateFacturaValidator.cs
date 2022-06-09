using FluentValidation;
using MinimercadoApp.Application.Requests;
using MiniMercadoApp.Application.Requests;

namespace MiniMercadoApp.Aplication.Validators
{
    public class CreateFacturasValidator : AbstractValidator<CreateFacturasRequest>
    {
        public CreateFacturasValidator()
        {
            RuleFor(x => x.IdFactura)
            .NotEmpty()
            .WithMessage("El Numero de Factura Es Obligatoria");

            RuleFor(x => x.Fecha)
                .NotEmpty()
                .WithMessage("La Fecha Es Obligatoria");

            RuleFor(x => x.ValorFactura)
                .NotEmpty()
                .WithMessage("Ingresa Valor de Factura");

            RuleFor(x => x.IdCliente)
                .NotEmpty()
                .WithMessage("Ingresa Identificación del Cliente");
        }
    }

    public class UpdateFacturasValidator : AbstractValidator<UpdateFacturasRequest>
    {
        public UpdateFacturasValidator()
        {
            RuleFor(x => x.IdFactura)
            .NotEmpty()
            .WithMessage("El Numero de Factura Es Obligatoria");

            RuleFor(x => x.Fecha)
                .NotEmpty()
                .WithMessage("La Fecha Es Obligatoria");

            RuleFor(x => x.ValorFactura)
                .NotEmpty()
                .WithMessage("Ingresa Valor de Factura");

            RuleFor(x => x.IdCliente)
                .NotEmpty()
                .WithMessage("Ingresa Identificación del Cliente");
        }
    }

    public class DeleteFacturasValidator : AbstractValidator<DeleteFacturasRequest>
    {
        public DeleteFacturasValidator()
        {
            RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage("El Numero de Factura Es Obligatoria");
        }
    }
}
