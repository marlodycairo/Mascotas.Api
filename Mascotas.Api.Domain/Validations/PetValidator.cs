using FluentValidation;
using Mascotas.Api.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mascotas.Api.Domain.Validations
{
    public class PetValidator : AbstractValidator<PetDto>
    {
        public PetValidator()
        {
            RuleFor(p => p.Name).NotNull()
                .NotEmpty().WithMessage("Ingrese el nombre de la mascota.");

            RuleFor(p => p.Race).NotNull()
                .NotEmpty().WithMessage("Debe ingresar la raza de la mascota");

            RuleFor(p => p.Born.ToShortDateString())
                .NotEmpty().WithMessage("Ingrese la fecha de nacimiento de su mascota");
        }
    }
}
