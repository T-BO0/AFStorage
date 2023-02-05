using AFStorage.Data;
using AFStorage.Models;
using Microsoft.EntityFrameworkCore;

namespace AFStorage.Services.ACFuelServices
{
    public class FuelServices : IFuelServices
    {
        private DataContext _dbContext;

        public FuelServices(DataContext dataContext)
        {
            _dbContext = dataContext;
        }


        public async Task<ACFuel> AddFuel(ACFuel fuel)
        {
            await _dbContext.ACFuels.AddAsync(fuel);

            await _dbContext.SaveChangesAsync();
            return fuel;
        }


        public async Task<List<ACFuel>?> DeleteFuel(int id)
        {
            var fuel = await _dbContext.ACFuels.FindAsync(id);
            if(fuel is null)
                return null;

            _dbContext.ACFuels.Remove(fuel);

            await _dbContext.SaveChangesAsync();
            return await _dbContext.ACFuels.ToListAsync();
        }


        public async Task<List<ACFuel>?> Get()
        {
            return await _dbContext.ACFuels.ToListAsync();
        }


        public async Task<ACFuel?> GetFuel(int id)
        {
            var fuel = await _dbContext.ACFuels.FindAsync(id);
            if(fuel is null)
                return null;

            return fuel;
        }


        public async Task<ACFuel?> UpdateFuel(int id, ACFuel update)
        {
            var fuel = await _dbContext.ACFuels.FindAsync(id);
            if(fuel is null)
                return null;

            fuel.Type = update.Type;
            fuel.Name = update.Name;
            fuel.ProviderCountry = update.ProviderCountry;
            fuel.AmountInStorageKG = update.AmountInStorageKG;

            await _dbContext.SaveChangesAsync();
            return fuel;
        }
    }
}