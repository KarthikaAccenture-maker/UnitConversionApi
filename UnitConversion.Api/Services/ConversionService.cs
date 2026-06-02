namespace UnitConversion.Api.Services
{
    public class ConversionService
    {
        public double Convert(double value, string fromUnit, string toUnit)
        {
            fromUnit = fromUnit.ToLower();
            toUnit = toUnit.ToLower();

            // Length calculation
            if (fromUnit == "meter" && toUnit == "foot")
                return value * 3.28084;

            if (fromUnit == "foot" && toUnit == "meter")
                return value / 3.28084;

            // Weight calculation
            if (fromUnit == "kilogram" && toUnit == "pound")
                return value * 2.20462;

            if (fromUnit == "pound" && toUnit == "kilogram")
                return value / 2.20462;

            // Temperature calculation
            if (fromUnit == "celsius" && toUnit == "fahrenheit")
                return value * 9 / 5 + 32;

            if (fromUnit == "fahrenheit" && toUnit == "celsius")
                return (value - 32) * 5 / 9;

            throw new Exception("Please check your input value");
        }
    }
}
