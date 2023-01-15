using Application.ViewModels.Products;
using FluentValidation;

namespace Application.Validators.Products
{
    public class CreateProductValidator : AbstractValidator<CreateProductVm>
    {
        public CreateProductValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Сураныч, продуктун атын созсуз жазыныз.")
                .MaximumLength(150)
                .MinimumLength(2)
                    .WithMessage("Сураныч, продуктун атыны 2 жана 150 символдун арасында кириниз.");

            RuleFor(p => p.Stock)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Сураныч, продуктун стогун бош жазбаныз.")
                .Must(s => s >= 0)
                    .WithMessage("Стог 0 же негатив болбойт");

            RuleFor(p => p.Price)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Сураныч, продуктун баасы бош жазбаныз.")
                .Must(s => s >= 0)
                    .WithMessage("Баа 0 же негатив болбойт")
    ;
        }
    }
}