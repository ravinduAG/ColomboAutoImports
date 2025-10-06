using ColomboAutoImports.Core.Entities;
using ColomboAutoImports.Core.Interfaces.Repositories;
using ColomboAutoImports.Core.Interfaces.Services;
using ColomboAutoImports.Core.Models;

namespace ColomboAutoImports.Core.Services
{
    public class CarModelService : ICarModelService
    {
        private readonly ICarModelRepository _carModelRepository;

        public CarModelService(ICarModelRepository carModelRepository)
        {
            _carModelRepository = carModelRepository;
        }

        public Task<IEnumerable<CarModelModel>> GetAllAsync() => _carModelRepository.GetAllAsync();
        public Task<CarModelModel> GetByIdAsync(int id) => _carModelRepository.GetByIdAsync(id);
        public Task<CarModelModel> AddAsync(CarModelModel carModel) => _carModelRepository.AddAsync(carModel);
        public Task<CarModelModel> UpdateAsync(CarModelModel carModel) => _carModelRepository.UpdateAsync(carModel);
        public Task DeleteAsync(int id) => _carModelRepository.DeleteAsync(id);
    }
}
