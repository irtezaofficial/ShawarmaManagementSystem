namespace ShawarmaManagementSystem
{
    internal class CancelledState : IOrderState
    {
        public string GetOrderState()
        {
            return "Cancelled";
        }

        public void ProcessOrder(OrderContext order)
        {
            MessageBox.Show("Cancelled orders can't be processed.");
        }

        public void DeliverOrder(OrderContext order)
        {
            MessageBox.Show("Cancelled orders can't be delivered.");
        }

        public void CancelOrder(OrderContext order)
        {
            MessageBox.Show("Order is already cancelled.");
        }

        public void CompleteOrder(OrderContext order)
        {
            MessageBox.Show("Cancelled orders can't be completed.");
        }
    }
}
