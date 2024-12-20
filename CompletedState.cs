namespace ShawarmaManagementSystem
{
    internal class CompletedState : IOrderState
    {
        public string GetOrderState()
        {
            return "Completed";
        }

        public void ProcessOrder(OrderContext order)
        {
            MessageBox.Show("Order is already completed.");
        }

        public void DeliverOrder(OrderContext order)
        {
            MessageBox.Show("Order is already completed, can't deliver it.");
        }

        public void CancelOrder(OrderContext order)
        {
            MessageBox.Show("Completed orders can't be cancelled.");
        }

        public void CompleteOrder(OrderContext order)
        {
            MessageBox.Show("Order is already completed.");
        }
    }
}
