using AFStorage.Models;
using AFStorage.Services.ACFuelServices;
using Microsoft.AspNetCore.Mvc;

namespace AFStorage.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ACFuelController : ControllerBase
    {
        private IFuelServices _fuelService;

        public ACFuelController(IFuelServices fuelServices)
       {
            _fuelService = fuelServices;
       }
        //get all the 
        [HttpGet]
        public async Task<ActionResult<List<ACFuel>>> Get()
        {
            var result = await _fuelService.Get();
            return Ok(result);
        }


        //get one fuel
        [HttpGet("{id}")]
        public async Task<ActionResult<ACFuel>> GetFuel(int id)
        {
            var result = await _fuelService.GetFuel(id);
            if(result is null)
                return NotFound("this fuel has not been found");

            return Ok(result);
        }


        //add fuel
        [HttpPost]
        public async Task<ActionResult<ACFuel>> AddFuel(ACFuel fuel)
        {
            var result = await _fuelService.AddFuel(fuel);
            return Ok(result);
        }


        //Update fuel
        [HttpPut("{id}")]
        public async Task<ActionResult<ACFuel>> UpdateFuel(int id, ACFuel update)
        {
            var result = await _fuelService.UpdateFuel(id, update);
            if(result is null)
                return NotFound("this fuel has not been found");

            return Ok(result);
        }


        //delete fuel
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<ACFuel>>> DeleteFuel(int id)
        {
            var result = await _fuelService.DeleteFuel(id);
            if(result is null)
                return NotFound("this fuel has not been found");

            return Ok(result);
        }
    }
}