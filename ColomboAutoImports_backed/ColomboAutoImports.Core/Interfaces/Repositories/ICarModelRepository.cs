using ColomboAutoImports.Core.Entities;
using ColomboAutoImports.Core.Models;

namespace ColomboAutoImports.Core.Interfaces.Repositories
{
    public interface ICarModelRepository
    {
        Task<IEnumerable<CarModelModel>> GetAllAsync();
        Task<CarModelModel> GetByIdAsync(int id);
        Task<CarModelModel> AddAsync(CarModelModel carModel);
        Task<CarModelModel> UpdateAsync(CarModelModel carModel);
        Task DeleteAsync(int id);
    }
}
