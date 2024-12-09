namespace ShawarmaManagementSystem
{
    internal class BillingContext
    {
        private IPaymentStrategy _paymentStrategy;
        public BillingContext(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        public void ExecutePayment(decimal amount)
        {
            _paymentStrategy.ProcessPayment(amount);
        }

        public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }
    }
}
