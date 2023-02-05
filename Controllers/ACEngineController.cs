using AFStorage.Models;
using AFStorage.Services.ACEngineServices;
using Microsoft.AspNetCore.Mvc;

namespace AFStorage.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ACEngineController : ControllerBase
    {
        IEngineServices _enginservices;
        public ACEngineController(IEngineServices engineServices)
        {
            _enginservices = engineServices;
        }

        //get all engines
        [HttpGet]
        public async Task<ActionResult<List<ACEngine>>> Get()
        {
            var result = await _enginservices.Get();
            return Ok(result);
        }
            


        //get one engine
        [HttpGet("{id}")]
        public async Task<ActionResult<ACEngine>> GetEngine(int id)
        {
            var result = await _enginservices.GetEngine(id);
            if(result is null)
                return NotFound("engine not found!!!");
            return Ok(result);
        }


        //add engine
        [HttpPost]
        public async Task<ActionResult<ACEngine>> AddEngine(ACEngine engine)
        {
            var result = await _enginservices.AddEngine(engine);
            return Ok(result);
        }


        //update engine
        [HttpPut("{id}")]
        public async Task<ActionResult<ACEngine>> UpdateEngine(int id, ACEngine update)
        {
            var result = await _enginservices.UpdateEngine(id, update);
            if(result is null)
                return NotFound("engine not found");
            return Ok(result);
        }


        //delete engine
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<ACEngine>>> deleteEngine(int id)
        {
            var result = await _enginservices.deleteEngine(id);
            if(result is null)
                return NotFound("engine found");
            return Ok(result);
        }
    }
}