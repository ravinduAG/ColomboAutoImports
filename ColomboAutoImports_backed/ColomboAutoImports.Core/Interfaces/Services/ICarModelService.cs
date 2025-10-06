using ColomboAutoImports.Core.Models;
using System.Threading.Tasks;

namespace ColomboAutoImports.Core.Interfaces.Services
{
    public interface ICarModelService
    {
        Task<IEnumerable<CarModelModel>> GetAllAsync();
        Task<CarModelModel> GetByIdAsync(int id);
        Task<CarModelModel> AddAsync(CarModelModel model);
        Task<CarModelModel> UpdateAsync(CarModelModel model);
        Task DeleteAsync(int id);
    }
}
