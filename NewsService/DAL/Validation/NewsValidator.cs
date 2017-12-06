using System;
using FluentValidation;
using NewsService.DAL.Models;

namespace NewsService.DAL.Validation
{
    public class NewsValidator : AbstractValidator<News>
    {
        public NewsValidator()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.Heading)
                .NotEmpty().WithMessage("Please enter News heading")
                .Length(5, 200).WithMessage(x => String.Format("minimum {0} and  maximum {1} characters", 5, 200));
            RuleFor(x => x.Text)
                .NotEmpty().WithMessage("Please enter News text")
                .Length(5, 2000).WithMessage(x => String.Format("minimum {0} and  maximum {1} characters", 5, 2000));
            RuleFor(x => x.Date)
                .NotEmpty().WithMessage("Please enter News date")
                .LessThan(p => DateTime.Now).WithMessage("Date must be past tense");
        }
    }
}
