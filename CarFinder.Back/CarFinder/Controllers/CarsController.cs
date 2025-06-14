using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarFinder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        [HttpGet("GetAllMakes")]
        public async Task <IActionResult> GetAllMakes()
        {
            return Ok();
        }

        [HttpGet("GetVehicleTypesForMakeById")]
        public async Task<IActionResult> GetVehicleTypesForMakeById()
        {
            return Ok();
        }

        [HttpGet("GetModelsForMakeId")]
        public async Task<IActionResult> GetModelsForMakeId()
        {
            return Ok();
        }
    }
}
