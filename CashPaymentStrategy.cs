namespace ShawarmaManagementSystem
{
    internal class CashPaymentStrategy : IPaymentStrategy
    {
        public void ProcessPayment(decimal amount)
        {
            MessageBox.Show($"Paid ${amount} through Cash successfully.");
        }
    }
}
