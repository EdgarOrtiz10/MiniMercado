using FluentValidation;
using MinimercadoApp.Application.Requests;
using MiniMercadoApp.Application.Requests;

namespace MiniMercadoApp.Aplication.Validators
{
    public class CreateClienteValidator : AbstractValidator<CreateClienteRequest>
    {
        public CreateClienteValidator()
        {
            RuleFor(x => x.IdCliente)
                .NotEqual(0)
                .WithMessage(" La identificación es requerida");

            RuleFor(x => x.Nombre1)
                .NotEmpty()
                .WithMessage(" Nombre  es requerido");

            RuleFor(x => x.Apellido1)
               .NotEmpty()
               .WithMessage("Apellido es requerido");

            RuleFor(x => x.Direccion)
                .NotEmpty()
                .WithMessage("La dirección es requerido");

            RuleFor(x => x.Telefono)
                  .NotEqual(0)
                  .WithMessage("Apellido es requerido");

            RuleFor(x => x.Sexo)
                .NotEmpty()
                .WithMessage("El sexo es requerido");

            RuleFor(x => x.Correo)
                .NotEmpty()
                .WithMessage("El Correo es requerido");
        }
    }

    public class UpdateClienteValidator : AbstractValidator<UpdateClienteRequest>
    {
        public UpdateClienteValidator()
        {
            RuleFor(x => x.IdCliente)
                .NotEqual(0)
                .WithMessage(" La identificación es requerida");

            RuleFor(x => x.Nombre1)
                .NotEmpty()
                .WithMessage(" Nombre  es requerido");

            RuleFor(x => x.Apellido1)
               .NotEmpty()
               .WithMessage("Apellido es requerido");

            RuleFor(x => x.Direccion)
                .NotEmpty()
                .WithMessage("La dirección es requerido");

            RuleFor(x => x.Telefono)
                  .NotEqual(0)
                  .WithMessage("Apellido es requerido");

            RuleFor(x => x.Sexo)
                .NotEmpty()
                .WithMessage("El sexo es requerido");

            RuleFor(x => x.Correo)
                .NotEmpty()
                .WithMessage("El Correo es requerido");
        }
    }

    public class DeleteClienteValidator : AbstractValidator<DeleteClienteRequest>
    {
        public DeleteClienteValidator()
        {
            RuleFor(x => x.Id)
                .NotEqual(0)
                .WithMessage(" La identificación es requerida");

         
        }
    }
}
