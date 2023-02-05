using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AFStorage.Models
{
    public class ACFuel
    {
        public int Id { get; set; }
        public string Type { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string ProviderCountry { get; set; } = string.Empty;
        public int AmountInStorageKG { get; set; }
    }
}