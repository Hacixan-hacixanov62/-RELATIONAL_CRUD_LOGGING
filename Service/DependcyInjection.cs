using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using Service.DTOs.Admin.Countries;
using Service.Services;
using Service.Services.Interfaces;

namespace Service
{
    public static class DependcyInjection
    {
        public static IServiceCollection AddServiceLayer(this IServiceCollection services)
        {
            services.AddFluentValidationAutoValidation(config =>
            {
                config.DisableDataAnnotationsValidation = true;
            });

            services.AddScoped<IValidator<CountryCreateDTO>, CountryCreateDtOValidator>();
            services.AddScoped<IValidator<CountryEditDTO>, CountryEditDtOValidator>();
            services.AddScoped<ICountryService, CountryService>();

            return services;
        }
    }
}
