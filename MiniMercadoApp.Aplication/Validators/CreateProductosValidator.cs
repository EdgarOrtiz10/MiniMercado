using FluentValidation;
using MiniMercadoApp.Application.Requests;

namespace MiniMercadoApp.Aplication.Validators
{
    public class CreateProductosValidator : AbstractValidator<CreateProductosRequest>
    {
        public CreateProductosValidator()
        {
            RuleFor(x => x.Precio)
                .NotEmpty()
                .WithMessage("Precio es requerido");

            
        }
    }
}
