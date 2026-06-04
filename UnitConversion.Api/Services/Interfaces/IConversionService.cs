using UnitConversion.Api.Models;
namespace UnitConversion.Api.Services.Interfaces
{
    public interface IConversionService
    {
        ConversionResponse Convert(ConversionRequest request);
    }
}
