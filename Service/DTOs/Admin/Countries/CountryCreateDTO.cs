using FluentValidation;

namespace Service.DTOs.Admin.Countries
{
    public class CountryCreateDTO
    {
        public string Name { get; set; }
    }

    public class CountryCreateDtOValidator : AbstractValidator<CountryCreateDTO>
    {
        public CountryCreateDtOValidator()
        {
            RuleFor(m => m.Name)
                .NotEmpty()
                .WithMessage("Name is required")
                .MaximumLength(100)
                .WithMessage("Name cannot exceed 100 characters");
        }
    }
}
