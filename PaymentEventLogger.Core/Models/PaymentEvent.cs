namespace PaymentEventLogger.Core
{
    public class PaymentEvent
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Provider { get; set; }        // Stripe, PayPal, Razorpay
        public string EventType { get; set; }       // payment_failed, payment_success
        public string Status { get; set; }          // Success / Failed / Processing
        public string ReferenceId { get; set; }     // Payment or Order ID

        public string Payload { get; set; }         // Raw JSON from gateway
        public string ErrorMessage { get; set; }    // Optional error

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
