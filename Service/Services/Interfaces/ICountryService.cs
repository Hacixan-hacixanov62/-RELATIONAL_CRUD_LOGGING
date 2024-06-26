using Service.DTOs.Admin.Countries;
using Service.DTOs.Admin.Country;

namespace Service.Services.Interfaces
{
    public interface ICountryService
    {
        Task CreateAsync(CountryCreateDTO data);
        Task EditAsync(int? id, CountryEditDTO data);
        Task DeleteAsync(int? id);
        Task<IEnumerable<CountryDTO>> GetAllAsync();
        Task<CountryDetialDTO> GetByIdAsync(int? id);
    }
}
