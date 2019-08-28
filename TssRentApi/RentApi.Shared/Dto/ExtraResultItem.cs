using System.Collections.Generic;

namespace RentApi.Shared.Dto
{
    public class ExtraResultItem
    {
        public List<Equipment> Equipments { get; set; }
        public CurrencyDetail Currency { get; set; }
        public int Tax { get; set; }
        public AdditionalKm AdditionalKm { get; set; }
        public List<Option> Included { get; set; }
        public List<Option> Optional { get; set; }
    }
}