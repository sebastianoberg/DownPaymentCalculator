using System.Threading.Tasks;
using DownPaymentCalculator.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DownPaymentCalculator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class DownPaymentController
    {
        private readonly ILogger<DownPaymentController> _logger;

        public DownPaymentController(ILogger<DownPaymentController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        [Route("{clientId}/invoice")]
        public async Task<int> DownPayment([FromBody] DownPaymentRequest request)
        {
            return 0;
        }
    }
}