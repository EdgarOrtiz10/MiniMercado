using FluentValidation;
using MinimercadoApp.Application.Requests;
using MiniMercadoApp.Application.Requests;

namespace MiniMercadoApp.Aplication.Validators
{
    public class CreateLoginValidator : AbstractValidator<CreateLoginRequest>
    {
        public CreateLoginValidator()
        {
            RuleFor(x => x.IdUser)
                .NotEqual(0)
                .WithMessage(" La identificación es requerida");

            RuleFor(x => x.Pass)
                .NotEmpty()
                .WithMessage("Contraseña Requerida");
        }
    }

}
