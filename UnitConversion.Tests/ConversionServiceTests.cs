using UnitConversion.Api.Services;
namespace UnitConversion.Tests;

public class ConversionServiceTests
{
    private readonly ConversionService _service;
    public ConversionServiceTests()
    {
        _service = new ConversionService();
    }

    [Fact]
    public void Meter_To_Foot_Should_Return_Correct_Value()
    {
        var result = _service.Convertion(1, "meter", "foot");
        Assert.Equal(3.28084, result, 5);
    }

    [Fact]
    public void Foot_To_Meter_Should_Return_Correct_Value()
    {
        var result = _service.Convertion(3.28084, "foot", "meter");
        Assert.Equal(1, result, 4);
    }

    [Fact]
    public void Kilogram_To_Pound_Should_Return_Correct_Value()
    {
        var result = _service.Convertion(1, "kilogram", "pound");          
        Assert.Equal(2.20462, result, 5);
    }

    [Fact]
    public void Pound_To_Kilogram_Should_Return_Correct_Value()
    {
        var result = _service.Convertion(2.20462, "pound", "kilogram");
        Assert.Equal(1, result, 4);
    }

    [Fact]
    public void Celsius_To_Fahrenheit_Should_Return_32()
    {
        var result = _service.Convertion(0, "celsius", "fahrenheit");
        Assert.Equal(32, result);
    }

    [Fact]
    public void Fahrenheit_To_Celsius_Should_Return_0()
    {
        var result = _service.Convertion(32, "fahrenheit", "celsius");
        Assert.Equal(0, result);
    }   
}
