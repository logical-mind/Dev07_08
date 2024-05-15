using FluentValidation;

namespace Okane.Application.Expenses.Create;

public class Validator : AbstractValidator<Request>
{
    public Validator()
    {
        RuleFor(request => request.Amount)
            .GreaterThan(-1)
            .WithMessage("Amount must be a positive value");

        RuleFor(request => request.Description)
            .MaximumLength(140)
            .WithMessage($"{nameof(Request.Description)} is too big");
    }
}