using AFStorage.Data;
using AFStorage.Models;
using Microsoft.EntityFrameworkCore;

namespace AFStorage.Services.ACEngineServices
{
    public class EngineServices : IEngineServices
    {
        private DataContext _dbContext;

        public EngineServices(DataContext dataContext)
        {
            _dbContext = dataContext;
        }

        
        public async Task<ACEngine> AddEngine(ACEngine engine)
        {
            await _dbContext.ACEngine.AddAsync(engine) ;

            await _dbContext.SaveChangesAsync();
            return engine;
        }

        public async Task<List<ACEngine>?> deleteEngine(int id)
        {
            var engine = await _dbContext.ACEngine.FindAsync(id);
            if(engine is null)
                return null;

            _dbContext.ACEngine.Remove(engine);

            await _dbContext.SaveChangesAsync();
            return await _dbContext.ACEngine.ToListAsync();
        }

        public async Task<List<ACEngine>?> Get()
        {
            return  await _dbContext.ACEngine.ToListAsync();
        }

        public async Task<ACEngine?> GetEngine(int id)
        {
            var engine = await _dbContext.ACEngine.FindAsync(id);
            if(engine is null)
                return null;
            
            return engine;
        }

        public async Task<ACEngine?> UpdateEngine(int id, ACEngine update)
        {
            var engine = await _dbContext.ACEngine.FindAsync(id);
            if(engine is null)
                return null;
            
            engine.Name = update.Name;
            engine.Type = update.Type;
            engine.ThrustGK = update.ThrustGK;
            engine.FuelConsumption = update.FuelConsumption;
            engine.AmountInStorage = update.AmountInStorage;

            await _dbContext.SaveChangesAsync();
            return engine;
        }
    }
}