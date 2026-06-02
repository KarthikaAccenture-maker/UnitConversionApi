using Microsoft.AspNetCore.Mvc;
using UnitConversion.Api.Models;
using UnitConversion.Api.Services;

namespace UnitConversion.Api.Controllers
{
    [ApiController]
    [Route("api/conversions")]
    public class ConversionController : ControllerBase
    {
        private readonly ConversionService _service;
        public ConversionController()
        {
            _service = new ConversionService();
        }

        [HttpPost]
        public IActionResult Convert(ConversionRequest request)
        {
            var result = _service.Convert( request.Value, request.FromUnit, request.ToUnit);

            return Ok(new ConversionResponse
            {
                OriginalValue = request.Value,
                FromUnit = request.FromUnit,
                ToUnit = request.ToUnit,
                ConvertedResultValue = result
            });
        }
    }
}
