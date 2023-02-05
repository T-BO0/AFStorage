using AFStorage.Models;

namespace AFStorage.Services.ACEngineServices
{
    public interface IEngineServices
    {
        Task<List<ACEngine>?> Get();
        Task<ACEngine?> GetEngine(int id);
        Task<ACEngine> AddEngine(ACEngine engine);
        Task<ACEngine?> UpdateEngine(int id, ACEngine update);
        Task<List<ACEngine>?> deleteEngine(int id);
    }
}