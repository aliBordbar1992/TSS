using System.Collections.Generic;

namespace RentApi.Shared
{
    public class ExtraResultItem
    {
        public CurrencyDetail Currency { get; set; }
        public int Tax { get; set; }
        public AdditionalKm AdditionalKm { get; set; }
        public List<Equipment> Equipments { get; set; }
        public List<Option> Included { get; set; }
        public List<Option> Optional { get; set; }
    }
}