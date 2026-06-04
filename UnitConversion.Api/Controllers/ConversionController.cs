using Microsoft.AspNetCore.Mvc;
using UnitConversion.Api.Models;
using UnitConversion.Api.Services.Interfaces;

namespace UnitConversion.Api.Controllers
{
    [ApiController]
    [Route("api/conversions")]
    public class ConversionController : ControllerBase
    {
        private readonly IConversionService _service;
        public ConversionController(IConversionService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Convert(ConversionRequest request)
        {
            var result = _service.Convert(request);
            return Ok(result);
        }
    }
}
