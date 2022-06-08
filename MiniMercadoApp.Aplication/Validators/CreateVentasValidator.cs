using FluentValidation;
using MiniMercadoApp.Application.Requests;

namespace MiniMercadoApp.Aplication.Validators
{
    public class CreateVentasValidator : AbstractValidator<CreateVentasRequest>
    {
        public CreateVentasValidator()
        {
            RuleFor(x => x.Cantidad)
                .NotEmpty()
                .WithMessage("Cantidad es requerida");

            
        }
    }
}
