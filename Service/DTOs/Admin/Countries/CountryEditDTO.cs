using FluentValidation;

namespace Service.DTOs.Admin.Countries
{
    public class CountryEditDTO
    {
        public string Name { get; set; }
    }


    public class CountryEditDtOValidator : AbstractValidator<CountryEditDTO>
    {
        public CountryEditDtOValidator()
        {
            RuleFor(m => m.Name)
                .NotEmpty()
                .WithMessage("Name is required")
                .MaximumLength(100)
                .WithMessage("Name cannot exceed 100 characters");
        }
    }
}
