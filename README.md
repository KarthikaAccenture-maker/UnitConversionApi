# Unit Conversion API

ASP.NET Core Web API for converting units.

## Supported Conversions

### Length
* Meter ? Foot
* Foot ? Meter

### Weight
* Kilogram ? Pound
* Pound ? Kilogram

### Temperature
* Celsius ? Fahrenheit
* Fahrenheit ? Celsius

## Prerequisites
* .NET 8 SDK or higher
* Visual Studio 2022

## Run
```bash
dotnet restore
dotnet build
dotnet run --project UnitConversion.Api
```

## Swagger
Open:
[http://localhost:5180/swagger](http://localhost:5180/swagger)

## Execute Tests
```bash
dotnet test
```

## Sample Request
```json
{
  "value": 100,
  "fromUnit": "meter",
  "toUnit": "foot"
}
```

## Design Decisions
- ASP.NET Core Web API
- Swagger for testing
- Service-based conversion logic
- Easily extensible for future unit types