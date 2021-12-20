using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class StudentValidator: AbstractValidator<Student>
    {
        public StudentValidator()
        {
            RuleFor(s => s.StudentEmail).NotEmpty();
            RuleFor(s => s.StudentName).NotEmpty();
            RuleFor(s => s.StudentLastName).NotEmpty();
            RuleFor(s => s.StudentNumber).GreaterThan(0);
            RuleFor(s => s.StudentPassword).NotEmpty();

        }
    }
}
