using AutoMapper;
using ColomboAutoImports.Core.Entities;
using ColomboAutoImports.Core.Interfaces.Repositories;
using ColomboAutoImports.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace ColomboAutoImports.Infrastructure.Repositories
{
    public class CarModelRepository : ICarModelRepository
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public CarModelRepository(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CarModelModel>> GetAllAsync()
        {
            var entities = await _context.CarModels.ToListAsync();
            return _mapper.Map<IEnumerable<CarModelModel>>(entities);
        }

        public async Task<CarModelModel?> GetByIdAsync(int id)
        {
            var entity = await _context.CarModels.FindAsync(id);
            return _mapper.Map<CarModelModel?>(entity);
        }

        public async Task<CarModelModel> AddAsync(CarModelModel model)
        {
            var entity = _mapper.Map<CarModelEntity>(model);
            _context.CarModels.Add(entity);
            await _context.SaveChangesAsync();
            return _mapper.Map<CarModelModel>(entity);
        }

        public async Task<CarModelModel> UpdateAsync(CarModelModel model)
        {
            var entity = await _context.CarModels.FindAsync(model.Id);
            if (entity == null) throw new KeyNotFoundException("Product not found");

            _mapper.Map(model, entity);
            await _context.SaveChangesAsync();
            return _mapper.Map<CarModelModel>(entity);
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.CarModels.FindAsync(id);
            if (entity == null) throw new KeyNotFoundException("Product not found");

            _context.CarModels.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
