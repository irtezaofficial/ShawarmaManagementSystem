namespace ShawarmaManagementSystem
{
    internal class CompletedState : IOrderState
    {
        public void ProcessOrder(Order order)
        {
            MessageBox.Show("Order is already completed.");
        }

        public void DeliverOrder(Order order)
        {
            MessageBox.Show("Order is already completed, can't deliver it.");
        }

        public void CancelOrder(Order order)
        {
            MessageBox.Show("Completed orders can't be cancelled.");
        }

        public void CompleteOrder(Order order)
        {
            MessageBox.Show("Order is already completed.");
        }
    }
}
