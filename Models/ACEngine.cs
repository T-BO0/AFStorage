namespace AFStorage.Models
{
    public class ACEngine
    {
        public int Id { get; set; }
        public string? Type { get; set; }
        public string? Name { get; set; } 
        public int ThrustGK { get; set; }
        public long FuelConsumption { get; set; }
        public int AmountInStorage { get; set; }
    }
}