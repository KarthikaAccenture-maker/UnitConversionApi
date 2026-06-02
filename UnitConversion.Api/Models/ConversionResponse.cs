namespace UnitConversion.Api.Models
{
    public class ConversionResponse
    {
        public double OriginalValue { get; set; }

        public string FromUnit { get; set; } = "";

        public string ToUnit { get; set; } = "";

        public double ConvertedResultValue { get; set; }
    }
}
