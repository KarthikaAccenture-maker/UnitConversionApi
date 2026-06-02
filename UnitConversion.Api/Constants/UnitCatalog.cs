namespace UnitConversion.Api.Constants
{
    public static class UnitCatalog
    {
        public static readonly Dictionary<string, string> Units = new(StringComparer.OrdinalIgnoreCase)
        {
            { "meter", "Length" },
            { "foot", "Length" },

            { "kilogram", "Weight" },
            { "pound", "Weight" },

            { "celsius", "Temperature" },
            { "fahrenheit", "Temperature" }
        };
    }
}
