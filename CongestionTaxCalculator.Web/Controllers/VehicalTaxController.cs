using CongestionTaxCalculator.Service.Dtos;
using CongestionTaxCalculator.Service.Service;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace CongestionTaxCalculator.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicalTaxController : ControllerBase
    {
        private readonly ICalculatorService calculatorService;

        public VehicalTaxController(ICalculatorService calculatorService)
        {
            this.calculatorService = calculatorService ?? throw new ArgumentNullException(nameof(calculatorService));
        }

        [HttpPost]
        [SwaggerResponse(200, null, typeof(int))]
        public async Task<IActionResult> GetAsync([FromBody] CongestionTaxVehicleDto congestionTaxVehicleDto, CancellationToken cancellationToken = default)
        {
            int amount = await this.calculatorService.GetTaxAsync(congestionTaxVehicleDto, cancellationToken);

            return Ok(amount);
        }
    }
}
