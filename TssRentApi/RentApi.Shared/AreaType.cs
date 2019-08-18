using System.Collections.Generic;

namespace RentApi.Shared
{
    public class AreaType
    {
        public static readonly AreaType City = new AreaType("C");
        public static readonly AreaType ChauffeurDriveStation = new AreaType("D");
        public static readonly AreaType EastSuburb = new AreaType("E");
        public static readonly AreaType RailwayStation = new AreaType("L", "X");
        public static readonly AreaType NorthSuburb = new AreaType("N");
        public static readonly AreaType OffTerminal = new AreaType("O");
        public static readonly AreaType FerryStation = new AreaType("P");
        public static readonly AreaType Ressort = new AreaType("R");
        public static readonly AreaType SouthSuburb = new AreaType("S");
        public static readonly AreaType AirportTerminal = new AreaType("T");
        public static readonly AreaType WestSuburb = new AreaType("W");

        public static IEnumerable<AreaType> Values
        {
            get
            {
                yield return City;
                yield return ChauffeurDriveStation;
                yield return EastSuburb;
                yield return RailwayStation;
                yield return NorthSuburb;
                yield return OffTerminal;
                yield return FerryStation;
                yield return Ressort;
                yield return SouthSuburb;
                yield return AirportTerminal;
                yield return WestSuburb;
            }
        }

        private readonly string[] _code;

        AreaType(params string[] code)
        {
            _code = code;
        }

        public string GetCode()
        {
            return _code[0];
        }

        public static AreaType FromCode(string code)
        {
            foreach (var size in Values)
            {
                foreach (var type in size._code)
                {
                    if (type.ToLower().Equals(code.ToLower()))
                        return size;
                }
            }

            return City;
        }
    }
}