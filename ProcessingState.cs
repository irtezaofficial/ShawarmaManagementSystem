namespace ShawarmaManagementSystem
{
    internal class ProcessingState : IOrderState
    {
        public string GetOrderState()
        {
            return "Processing";
        }

        public void ProcessOrder(OrderContext order)
        {
            MessageBox.Show("Order is already being processed.");
        }

        public void DeliverOrder(OrderContext order)
        {
            order.SetOrderState(new DeliveredState());
            MessageBox.Show("Order is now delivered.");
        }

        public void CancelOrder(OrderContext order)
        {
            order.SetOrderState(new CancelledState());
            MessageBox.Show("Order has been cancelled.");
        }

        public void CompleteOrder(OrderContext order)
        {
            order.SetOrderState(new CompletedState());
            MessageBox.Show("Order is now completed.");
        }
    }
}
