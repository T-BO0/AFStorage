using AFStorage.Models;

namespace AFStorage.Services.ACFuelServices
{
    public interface IFuelServices
    {
        Task<List<ACFuel>?> Get();
        Task<ACFuel?> GetFuel(int id);
        Task<ACFuel> AddFuel(ACFuel fuel);
        Task<ACFuel?> UpdateFuel(int id, ACFuel update);
        Task<List<ACFuel>?> DeleteFuel(int id);

    }
}