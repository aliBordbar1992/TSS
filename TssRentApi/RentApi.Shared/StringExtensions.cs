using System;

namespace RentApi.Shared
{
    public static class StringExtensions
    {
        public static string CheckDateFormat(this string input, string format)
        {
            DateTime dDate;

            if (DateTime.TryParse(input, out dDate))
            {
                return input;
            }
            else
            {
                throw new ArgumentException($"{input} is not a valid date format, it should be {format}");
            }
            
        }
    }
}