using FluentValidation;
using MiniMercadoApp.Application.Requests;

namespace MiniMercadoApp.Aplication.Validators
{
    public class CreateFacturasValidator : AbstractValidator<CreateFacturasRequest>
    {
        public CreateFacturasValidator()
        {
            RuleFor(x => x.Fecha)
                .NotEmpty()
                .WithMessage("La Identificación Es Obligatoria");

            RuleFor(x => x.ValorFactura)
                .NotEmpty()
                .WithMessage("Ingresa Nombre de Categoria");
        }
    }
}
