namespace ShawarmaManagementSystem
{
    internal class IdleState : IOrderState
    {
        public string GetOrderState()
        {
            return "Idle";
        }

        public void ProcessOrder(OrderContext order)
        {
            order.SetOrderState(new ProcessingState());
            MessageBox.Show("Order now being processed.");
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
