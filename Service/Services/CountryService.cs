using AutoMapper;
using Domain.Entities;
using Repository.Repositories.Interfaces;
using Service.DTOs.Admin.Countries;
using Service.DTOs.Admin.Country;
using Service.Helpers.Exceptions;
using Service.Services.Interfaces;

namespace Service.Services
{
    public class CountryService : ICountryService
    {
        private readonly ICountryRepository _countryRepository;
        private readonly IMapper _mapper;

        public CountryService(ICountryRepository countryRepository,
                              IMapper mapper)
        {
            _countryRepository = countryRepository;
            _mapper = mapper;
        }

        public async Task CreateAsync(CountryCreateDTO data)
        {
            if (data is null) throw new ArgumentNullException(nameof(data));

            await _countryRepository.CreateAsync(_mapper.Map<Country>(data));
        }

        public async Task EditAsync(int? id, CountryEditDTO data)
        {
            if (id is null) throw new ArgumentNullException(nameof(id));

            if (data is null) throw new ArgumentNullException(nameof(data));

            var country = await _countryRepository.GetByIdAsync((int)id) ?? throw new NotFoundException("Data not found");

            _mapper.Map(data, country);
            await _countryRepository.EditAsync(country);
        }

        public async Task DeleteAsync(int? id)
        {
            if (id is null) throw new ArgumentNullException(nameof(id));

            var country = await _countryRepository.GetByIdAsync((int)id) ?? throw new NotFoundException("Data not found");

            await _countryRepository.DeleteAsync(country);

        }

        public async Task<IEnumerable<CountryDTO>> GetAllAsync()
        {
            return _mapper.Map<IEnumerable<CountryDTO>>(await _countryRepository.GetAllAsync());
        }

        public async Task<CountryDetialDTO> GetByIdAsync(int? id)
        {
            if (id is null) throw new ArgumentNullException(nameof(id));

            var country = await _countryRepository.GetByIdAsync((int)id) ?? throw new NotFoundException("Data not found");

            return _mapper.Map<CountryDetialDTO>(country);
        }
    }
}
