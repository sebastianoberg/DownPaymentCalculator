using System.Threading.Tasks;
using DownPaymentCalculator.Contracts;
using DownPaymentCalculator.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DownPaymentCalculator.Controllers
{
    [ApiController]
    [Route("api")]
    [Produces("application/json")]
    public class DownPaymentController
    {
        private readonly IDownPaymentCalculationService _downPaymentCalculationService;
        private readonly ILogger<DownPaymentController> _logger;

        public DownPaymentController(ILogger<DownPaymentController> logger, IDownPaymentCalculationService downPaymentCalculationService)
        {
            _logger = logger;
            _downPaymentCalculationService = downPaymentCalculationService;
        }

        [HttpPost]
        [Route("totaldownpayment")]
        public DownPaymentResponse DownPayment([FromBody] DownPaymentRequest request)
        {
            var summaryResult = _downPaymentCalculationService.CalculateTotalDownPayment(request);
            return summaryResult;
        }
    }
}