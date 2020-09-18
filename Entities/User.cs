using System;
using System.Globalization;

namespace TestIFormatable.Entities
{
    public class User : IFormattable
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (formatProvider == null)
            {
                formatProvider = CultureInfo.CurrentCulture;
            }

            switch ((format ?? "").ToUpperInvariant())
            {
                default:
                case "O":
                    return $"Id = {Id}, Firstname = {Firstname}, Lastname = {Lastname}";
                case "J":
                    return $"{{{nameof(Id)}:{Id},{nameof(Firstname)}:\"{Firstname}\",{nameof(Lastname)}:\"{Lastname}\"}}";
            }
        }
    }
}
