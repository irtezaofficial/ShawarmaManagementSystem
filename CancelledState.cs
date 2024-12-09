namespace ShawarmaManagementSystem
{
    internal class CancelledState : IOrderState
    {
        public void ProcessOrder(Order order)
        {
            MessageBox.Show("Cancelled orders can't be processed.");
        }

        public void DeliverOrder(Order order)
        {
            MessageBox.Show("Cancelled orders can't be delivered.");
        }

        public void CancelOrder(Order order)
        {
            MessageBox.Show("Order is already cancelled.");
        }

        public void CompleteOrder(Order order)
        {
            MessageBox.Show("Cancelled orders can't be completed.");
        }
    }
}
