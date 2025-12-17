using Microsoft.AspNetCore.Mvc;
using PaymentEventLogger.Core;

namespace PaymentEventLogger.SampleApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentEventController : ControllerBase
    {
        private readonly IPaymentEventLogger _paymentEventLogger;

        // Inject the IPaymentEventLogger via constructor dependency injection
        public PaymentEventController(IPaymentEventLogger paymentEventLogger)
        {
            _paymentEventLogger = paymentEventLogger;
        }

        // POST endpoint to log payment events
        [HttpPost("log-payment")]
        public async Task<IActionResult> LogPaymentEvent([FromBody] PaymentEvent paymentEvent)
        {
            // Log the payment event
            await _paymentEventLogger.LogAsync(paymentEvent);
            return Ok("Payment event logged successfully!");
        }
    }
}
