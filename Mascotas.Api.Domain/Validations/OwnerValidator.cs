using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using Mascotas.Api.Domain.Models;

namespace Mascotas.Api.Domain.Validations
{
    public class OwnerValidator : AbstractValidator<OwnerDto>
    {
        public OwnerValidator()
        {
            RuleFor(p => p.Address).NotNull()
                .NotEmpty().WithMessage("Ingrese la dirección de residencia de la mascota.");

            RuleFor(p => p.CellPhone).NotNull()
                .NotEmpty().WithMessage("Debe ingresar un número de celular de contacto.");

            RuleFor(p => p.EMail)
                .NotEmpty().WithMessage("Ingrese un correo electrónico válido.");

            RuleFor(p => p.FirstName).NotNull()
                .NotEmpty().WithMessage("Ingrese el nombre del propietario de la mascota.");

            RuleFor(p => p.LastName).NotNull()
                .NotEmpty().WithMessage("Debe ingresar el apellido del propietario de la mascota");

            RuleFor(p => p.IdentificationCard).NotNull()
                .NotEmpty().WithMessage("Ingrese el numero del documento de identificación.")
                .NotEqual("0").WithMessage("Debe ingrese un número valido de identificación.");
        }
    }
}
