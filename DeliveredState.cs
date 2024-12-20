namespace ShawarmaManagementSystem
{
    internal class DeliveredState : IOrderState
    {
        public string GetOrderState()
        {
            return "Delivered";
        }

        public void ProcessOrder(OrderContext order)
        {
            MessageBox.Show("Order has already been delivered, can't process it.");
        }

        public void DeliverOrder(OrderContext order)
        {
            MessageBox.Show("Order is already delivered.");
        }

        public void CancelOrder(OrderContext order)
        {
            MessageBox.Show("Order can't be cancelled after delivery.");
        }

        public void CompleteOrder(OrderContext order)
        {
            order.SetOrderState(new CompletedState());
            MessageBox.Show("Order is now completed.");
        }
    }
}
