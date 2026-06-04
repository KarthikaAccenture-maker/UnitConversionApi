using UnitConversion.Api.Constants;
using UnitConversion.Api.Models;
using UnitConversion.Api.Services.Interfaces;

namespace UnitConversion.Api.Services
{
    public class ConversionService : IConversionService
    {
        public ConversionResponse Convert(ConversionRequest request)
        {
            double convertedValue = Convertion(request.Value, request.FromUnit, request.ToUnit);
            return new ConversionResponse
            {
                OriginalValue = request.Value,
                FromUnit = request.FromUnit,
                ToUnit = request.ToUnit,
                ConvertedResultValue = convertedValue
            };
        }
        public double Convertion(double value, string fromUnit, string toUnit)
        {
            fromUnit = fromUnit.ToLower();
            toUnit = toUnit.ToLower();
            ValidateUnits(fromUnit, toUnit);

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

        private void ValidateUnits(string fromUnit, string toUnit)
        {
            if (!UnitCatalog.Units.ContainsKey(fromUnit))
            {
                throw new ArgumentException($"Invalid source unit '{fromUnit}'.");
            }

            if (!UnitCatalog.Units.ContainsKey(toUnit))
            {
                throw new ArgumentException($"Invalid target unit '{toUnit}'.");
            }
        }
    }
}
