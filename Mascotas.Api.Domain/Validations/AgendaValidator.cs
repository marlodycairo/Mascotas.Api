using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using Mascotas.Api.Domain.Models;

namespace Mascotas.Api.Domain.Validations
{
    public class AgendaValidator : AbstractValidator<AgendaDto>
    {
        public AgendaValidator()
        {
            RuleFor(p => p.Comment).NotNull()
                .NotEmpty().WithMessage("Ingrese un comentario o motivo de consulta sobre la atención a realizar a la mascota.");

            RuleFor(p => p.Date.ToShortDateString())
                .NotEmpty().WithMessage("Ingrese la fecha y hora para la cita.");
        }
    }
}
