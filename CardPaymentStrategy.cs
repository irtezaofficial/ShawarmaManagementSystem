namespace ShawarmaManagementSystem
{
    internal class CardPaymentStrategy : IPaymentStrategy
    {
        private string _cardNumber;
        public CardPaymentStrategy(string cardNumber)
        {
            _cardNumber = cardNumber;
        }

        public void ProcessPayment(decimal amount)
        {
            MessageBox.Show($"Paid ${amount} through Card successfully.");
        }
    }
}
