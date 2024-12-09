namespace ShawarmaManagementSystem
{
    internal class SplitPaymentStrategy : IPaymentStrategy
    {
        private decimal _firstPaymentAmount;
        private decimal _secondPaymentAmount;

        private readonly IPaymentStrategy _firstPaymentMethod;
        private readonly IPaymentStrategy _secondPaymentMethod;

        public SplitPaymentStrategy(
            decimal firstPaymentAmount,
            decimal secondPaymentAmount,
            IPaymentStrategy firstPaymentMethod, 
            IPaymentStrategy secondPaymentMethod)
        {
            _firstPaymentAmount = firstPaymentAmount;
            _secondPaymentAmount = secondPaymentAmount;
            _firstPaymentMethod = firstPaymentMethod;
            _secondPaymentMethod = secondPaymentMethod;
        }

        public void SetPayment(decimal firstPaymentAmount,  decimal secondPaymentAmount)
        {
            _firstPaymentAmount = firstPaymentAmount;
            _secondPaymentAmount = secondPaymentAmount;
        }

        public void ProcessPayment(decimal totalAmount)
        {
            if(totalAmount != (_firstPaymentAmount + _secondPaymentAmount))
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _firstPaymentMethod.ProcessPayment(_firstPaymentAmount);
            _secondPaymentMethod.ProcessPayment(_secondPaymentAmount);
        }
    }
}
