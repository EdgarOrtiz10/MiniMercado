using FluentValidation;
using MiniMercadoApp.Application.Requests;

namespace MiniMercadoApp.Aplication.Validators
{
    public class CreateProveedoresValidator : AbstractValidator<CreateProveedoresRequest>
    {
        public CreateProveedoresValidator()
        {
            RuleFor(x => x.NombreProveedor)
                .NotEmpty()
                .WithMessage("Nombre Proveedor es requerido");

            
        }
    }
}
