namespace ShawarmaManagementSystem
{
    interface IPaymentStrategy
    {
        void ProcessPayment(decimal amount);
    }
}
