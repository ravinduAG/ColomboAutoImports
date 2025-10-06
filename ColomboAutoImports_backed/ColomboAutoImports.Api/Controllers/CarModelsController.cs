using ColomboAutoImports.Core.Interfaces.Services;
using ColomboAutoImports.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace ColomboAutoImports.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarModelsController : ControllerBase
    {
        private readonly ICarModelService _carModelService;

        public CarModelsController(ICarModelService carModelService)
        {
            _carModelService = carModelService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() {
            return Ok(await _carModelService.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var product = await _carModelService.GetByIdAsync(id);
            return product == null ? NotFound() : Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CarModelModel model)
        {
            var created = await _carModelService.AddAsync(model);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, CarModelModel model)
        {
            if (id != model.Id) return BadRequest();
            var updated = await _carModelService.UpdateAsync(model);
            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _carModelService.DeleteAsync(id);
            return NoContent();
        }
    }
}
