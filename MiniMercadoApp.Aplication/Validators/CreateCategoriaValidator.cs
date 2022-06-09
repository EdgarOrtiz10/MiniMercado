using FluentValidation;
using MinimercadoApp.Application.Requests;
using MiniMercadoApp.Application.Requests;

namespace MiniMercadoApp.Aplication.Validators
{
    public class CreateCategoriaValidator : AbstractValidator<CreateCategoriaRequest>
    {
        public CreateCategoriaValidator()
        {
            RuleFor(x => x.IdCategoria)
                .NotEqual(0)
                .WithMessage("La Identificación Es Obligatoria");

            RuleFor(x => x.NombreCategoria)
                .NotEqual("")
                .WithMessage("Ingresa Nombre de Categoria");
        }
    }

    public class UpdateCategoriaValidator : AbstractValidator<UpdateCategoriaRequest>
    {
        public UpdateCategoriaValidator()
        {
            RuleFor(x => x.IdCategoria)
                .NotEqual(0)
                .WithMessage("La Identificación Es Obligatoria");

            RuleFor(x => x.NombreCategoria)
                .NotEqual("")
                .WithMessage("Ingresa Nombre de Categoria");
        }
    }

    public class DeleteCategoriaValidator : AbstractValidator<DeleteCategoriaRequest>
    {
        public DeleteCategoriaValidator()
        {
            RuleFor(x => x.Id)
                .NotEqual(0)
                .WithMessage("La Identificación Es Obligatoria");

        }
    }
}
