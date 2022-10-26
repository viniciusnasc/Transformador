﻿using FluentValidation;
using Transformador.Domain.Entities;

namespace Transformador.Domain.Validacoes
{
    public class ReportValidation : AbstractValidator<Report>
    {
        public ReportValidation()
        {
            RuleFor(f => f.Name)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2, 100)
                .WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            RuleFor(f => f.Status)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido");
        }
    }
}