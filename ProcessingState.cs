namespace ShawarmaManagementSystem
{
    internal class ProcessingState : IOrderState
    {
        public void ProcessOrder(Order order)
        {
            MessageBox.Show("Order is already being processed.");
        }

        public void DeliverOrder(Order order)
        {
            order.SetOrderState(new DeliveredState());
            MessageBox.Show("Order is now delivered.");
        }

        public void CancelOrder(Order order)
        {
            order.SetOrderState(new CancelledState());
            MessageBox.Show("Order has been cancelled.");
        }

        public void CompleteOrder(Order order)
        {
            order.SetOrderState(new CompletedState());
            MessageBox.Show("Order is now completed.");
        }
    }
}
