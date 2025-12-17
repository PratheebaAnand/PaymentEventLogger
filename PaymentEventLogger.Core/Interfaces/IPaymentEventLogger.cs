namespace PaymentEventLogger.Core
{
    public interface IPaymentEventLogger
    {
        Task LogAsync(PaymentEvent paymentEvent);
    }
}
