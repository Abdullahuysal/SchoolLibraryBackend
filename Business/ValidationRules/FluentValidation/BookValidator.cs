using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class BookValidator : AbstractValidator<Book>
    {
        public BookValidator()
        {
            RuleFor(b => b.BookName).NotEmpty();
            RuleFor(b => b.BookAuthor).NotEmpty();
            RuleFor(b => b.BookCategory).NotEmpty();
            RuleFor(b => b.BookPageCount).GreaterThan(0);
        }
    }
}
