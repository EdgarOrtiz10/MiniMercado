using FluentValidation;
using MinimercadoApp.Application.Requests;
using MiniMercadoApp.Application.Requests;

namespace MiniMercadoApp.Aplication.Validators
{
    public class CreateProveedoresValidator : AbstractValidator<CreateProveedoresRequest>
    {
        public CreateProveedoresValidator()
        {
            RuleFor(x => x.IdProveedor)
                .NotEmpty()
                .WithMessage("La Identificación del Proveedor es Requerida");

            RuleFor(x => x.NombreProveedor)
                .NotEmpty()
                .WithMessage("El Nombre Proveedor es requerido");

            RuleFor(x => x.DireccionProveedor)
                .NotEmpty()
                .WithMessage("La Dirección del Proveedor es requerido");

            RuleFor(x => x.TelefonoProveedor)
                .NotEmpty()
                .WithMessage("El Telefono del Proveedor es requerido");

            RuleFor(x => x.Correo)
                .NotEmpty()
                .WithMessage("El Correo del Proveedor es requerido");
        }
    }
    public class UpdateProveedoresValidator : AbstractValidator<UpdateProveedoresRequest>
    {
        public UpdateProveedoresValidator()
        {
            RuleFor(x => x.IdProveedor)
                .NotEmpty()
                .WithMessage("La Identificación del Proveedor es Requerida");

            RuleFor(x => x.NombreProveedor)
                .NotEmpty()
                .WithMessage("El Nombre Proveedor es requerido");

            RuleFor(x => x.DireccionProveedor)
                .NotEmpty()
                .WithMessage("La Dirección del Proveedor es requerido");

            RuleFor(x => x.TelefonoProveedor)
                .NotEmpty()
                .WithMessage("El Telefono del Proveedor es requerido");

            RuleFor(x => x.Correo)
                .NotEmpty()
                .WithMessage("El Correo del Proveedor es requerido");
        }
    }

    public class DeleteProveedoresValidator : AbstractValidator<DeleteProveedoresRequest>
    {
        public DeleteProveedoresValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("La Identificación del Proveedor es Requerida");
        }
    }

}
