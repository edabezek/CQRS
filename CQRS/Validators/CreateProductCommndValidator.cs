using CQRS.WebApi.Features.ProductFeatures.Commands;
using FluentValidation;

namespace CQRS.WebApi.Validators
{
    public class CreateProductCommndValidator : AbstractValidator<CreateProductCommand>
{
    public CreateProductCommndValidator()
    {
        RuleFor(c => c.Barcode).NotEmpty();
        RuleFor(c => c.Name).NotEmpty();
    }
}
}
