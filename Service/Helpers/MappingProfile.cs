using AutoMapper;
using Domain.Entities;
using Service.DTOs.Admin.Countries;
using Service.DTOs.Admin.Country;

namespace Service.Helpers
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Country, CountryDTO>();
            CreateMap<Country, CountryDetialDTO>();
            CreateMap<CountryCreateDTO, Country>();
            CreateMap<CountryEditDTO, Country>();
        }
    }
}
