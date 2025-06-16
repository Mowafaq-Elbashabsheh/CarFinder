using CarFinder.Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarFinder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ICarService _carService;
        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("GetAllMakes")]
        public async Task <IActionResult> GetAllMakes()
        {
            try
            {
                var response = await _carService.GetAllMakes();
                return Ok(response);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpGet("GetVehicleTypesForMakeById")]
        public async Task<IActionResult> GetVehicleTypesForMakeById(int id)
        {
            try
            {
                var response = await _carService.GetVehicleTypesForMakeById(id);
                return Ok(response);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpGet("GetModelsForMakeId")]
        public async Task<IActionResult> GetModelsForMakeId(int id, int year)
        {
            try
            {
                var response = await _carService.GetModelsForMakeId(id, year);
                return Ok(response);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
